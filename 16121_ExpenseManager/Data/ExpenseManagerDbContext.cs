using _16121_ExpenseManager.Models;
using Microsoft.EntityFrameworkCore;

namespace _16121_ExpenseManager.Data
{
    public class ExpenseManagerDbContext: DbContext
    {
        public ExpenseManagerDbContext(DbContextOptions<ExpenseManagerDbContext> options) : base(options)
        {
        }


        public DbSet<Expense> Expenses16121 { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
