using Microsoft.AspNetCore.Mvc;
using WebApi_Livros.Domain.Service;

namespace WebApi_Livros.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _categoryService.ListAsycn();
            return Ok(categories);
        }
    }
}
