using WebApi_Livros.Domain.Models;

namespace WebApi_Livros.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsycn();
    }
}
