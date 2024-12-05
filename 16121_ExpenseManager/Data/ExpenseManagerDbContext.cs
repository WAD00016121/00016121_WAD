using _16121_ExpenseManager.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace _16121_ExpenseManager.Data
{
    public class ExpenseManagerDbContext: DbContext
    {
        public ExpenseManagerDbContext(DbContextOptions<ExpenseManagerDbContext> options) : base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
