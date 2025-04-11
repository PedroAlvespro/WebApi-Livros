using Microsoft.EntityFrameworkCore;
using WebApi_Livros.Domain.Models;
using WebApi_Livros.Domain.Repositories;

namespace WebApi_Livros.Persistence.Repositories
{
    public class CategoryRepository :  BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
        public Task<IEnumerable<Category>> ListAsycn()
        {
            throw new NotImplementedException();
        }
    }
}
