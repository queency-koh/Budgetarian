using Budgetarian.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Budgetarian.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.Categories.Any())
            {
                return;
            }

            var categories = new List<Category>
            {
                new Category { Name = "Lifestyle", Budget = 8000 },
                new Category { Name = "Bills", Budget = 20000 },
                new Category { Name = "Loans", Budget = 20000 },
                new Category { Name = "Transportation", Budget = 4000 },
                new Category { Name = "Grocery", Budget = 5000 },
                new Category { Name = "Miscellaneous", Budget = 5000 },
            };

            context.Categories.AddRange(categories);
            context.SaveChanges();
        }
    }
}
