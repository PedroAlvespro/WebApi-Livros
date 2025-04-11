using WebApi_Livros.Domain.Models;

namespace WebApi_Livros.Domain.Service
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsycn();
    }
}
