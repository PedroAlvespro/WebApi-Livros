using WebApi_Livros.Domain.Models;
using WebApi_Livros.Domain.Repositories;
using WebApi_Livros.Domain.Service;

namespace WebApi_Livros.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<Category>> ListAsycn()
        {
            return null;
        }
    }
}
