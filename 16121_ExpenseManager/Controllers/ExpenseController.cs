using _16121_ExpenseManager.Data;
using _16121_ExpenseManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace _16121_ExpenseManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly ExpenseManagerDbContext _context16121;
        public ExpenseController(ExpenseManagerDbContext context)
        {
            _context16121 = context;
        }


        [HttpGet]
        public IActionResult GetAllExpenses()
        {
            return Ok(_context16121.Expenses16121.ToList());
        }


        [HttpPost]
        public IActionResult CreateExpense(Expense expense)
        {
            _context16121.Expenses16121.Add(expense);
            _context16121.SaveChanges();
            return Ok(expense);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateExpense(int id, Expense expense)
        {
            var existingExpense = _context16121.Expenses16121.Find(id);
            if (existingExpense == null) return NotFound();

            existingExpense.Title = expense.Title;
            existingExpense.Amount = expense.Amount;
            existingExpense.Date = expense.Date;
            existingExpense.CategoryId = expense.CategoryId;

            _context16121.SaveChanges();
            return Ok(existingExpense);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteExpense(int id)
        {
            var expense = _context16121.Expenses16121.Find(id);
            if (expense == null) return NotFound();

            _context16121.Expenses16121.Remove(expense);
            _context16121.SaveChanges();
            return Ok();
        }


    }
}
