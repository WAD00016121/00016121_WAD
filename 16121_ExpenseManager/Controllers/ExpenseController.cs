using _16121_ExpenseManager.Data;
using _16121_ExpenseManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _16121_ExpenseManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly ExpenseManagerDbContext _context;

        public ExpenseController(ExpenseManagerDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllExpenses()
        {
            return Ok(_context.Expenses.ToList());
        }

        [HttpPost]
        public IActionResult CreateExpense(Expense expense)
        {
            _context.Expenses.Add(expense);
            _context.SaveChanges();
            return Ok(expense);
        }
    }
}
