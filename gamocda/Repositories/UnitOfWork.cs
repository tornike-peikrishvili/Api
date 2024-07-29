using gamocda.Data;
using gamocda.Models;

namespace gamocda.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PublishingContext _context;
        public IRepository<Author> Authors { get; }
        public IRepository<Product> Products { get; }

        public UnitOfWork(PublishingContext context)
        {
            _context = context;
            Authors = new Repository<Author>(_context);
            Products = new Repository<Product>(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}