using Budgetarian.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Budgetarian.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
