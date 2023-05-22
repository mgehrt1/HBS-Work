using ASP_MVCApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_MVCApp.Data {
    public class ApplicationDbContext :DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
            
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
