using _16121_ExpenseManager.Data;
using _16121_ExpenseManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _16121_ExpenseManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ExpenseManagerDbContext _context;

        public CategoryController(ExpenseManagerDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            return Ok(_context.Categories.ToList());
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return Ok(category);
        }
    }
}
