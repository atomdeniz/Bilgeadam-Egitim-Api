using BilgeadamEgitim.Core.Services;
using BilgeadamEgitim.Core.UOW;
using BilgeadamEgitim.DataAccess;
using BilgeadamEgitim.DataAccess.UOW;
using BilgeadamEgitim.Services.Services;
using BilgeadamEgitim.WebAPI.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace BilgeadamEgitim.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //services.AddDbContext<BlogDbContext>(options => options.UseSqlServer())


            services.AddAutoMapper(typeof(Startup));
            //services.AddControllers();
            services.AddControllers(options => { options.Filters.Add(new ApiExceptionFilter()); });
            
            services.AddScoped<IUnitOfWork, UnitOfWork>(); //her request süresince kullanılır
            services.AddTransient<IContentService, ContentService>();
            //services.AddTransient() //her servis çağırıldığında
            //services.AddSingleton() //uygulama ayağa kalktığında bir kez oluşur

            services.AddDbContext<BlogDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DevConnection"), x => x.MigrationsAssembly("BilgeadamEgitim.DataAccess")));

            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });


            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
