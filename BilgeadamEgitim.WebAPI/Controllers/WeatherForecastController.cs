using BilgeadamEgitim.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeadamEgitim.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {



        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get(Student student)
        //{
          
        //}



        [HttpGet("{id}")]
        public WeatherForecast Get(int id)
        {


            var rng = new Random();
            var weatherArray =  Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();

            if (weatherArray.Length > id)
            {
                return weatherArray[id];
            }
            else
            {
                return null;
            }

        }



        [HttpPost]

        public IEnumerable<WeatherForecast> Post(Student student)
        {
            return null;
        }
    }
}
