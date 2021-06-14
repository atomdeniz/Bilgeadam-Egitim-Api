using BilgeadamEgitim.Core.Repositories;
using BilgeadamEgitim.Core.UOW;
using System.Threading.Tasks;

namespace BilgeadamEgitim.DataAccess.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogDbContext _context;


        private ContentRepository _contentRepository;
        private UserRepository _userRepository;


        public UnitOfWork(BlogDbContext context)
        {
            this._context = context;
        }

        public IContentRepository Contents => _contentRepository = _contentRepository ?? new ContentRepository(_context);

        public IUserRepository Users => _userRepository = _userRepository ?? new UserRepository(_context);


        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
