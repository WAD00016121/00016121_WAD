using _16121_ExpenseManager.Data;
using _16121_ExpenseManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace _16121_ExpenseManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ExpenseManagerDbContext _context16121;
        public CategoryController(ExpenseManagerDbContext context)
        {
            _context16121 = context;
        }


        [HttpGet]
        public IActionResult GetAllCategories()
        {
            return Ok(_context16121.Categories.ToList());
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _context16121.Categories.Add(category);
            _context16121.SaveChanges();
            return Ok(category);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int id, Category category)
        {
            var existingCategory = _context16121.Categories.Find(id);
            if (existingCategory == null) return NotFound();

            existingCategory.Name = category.Name;
            _context16121.SaveChanges();
            return Ok(existingCategory);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = _context16121.Categories.Find(id);
            if (category == null) return NotFound();

            _context16121.Categories.Remove(category);
            _context16121.SaveChanges();
            return Ok();
        }


    }
}
