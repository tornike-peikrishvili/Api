using gamocda.Models;
using gamocda.Repositories;
using System.Threading.Tasks;

namespace gamocda.Repositories
{
    public interface IUnitOfWork
    {
        IRepository<Author> Authors { get; }
        IRepository<Product> Products { get; }
        Task<int> CompleteAsync();
    }
}