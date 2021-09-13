using Budgetarian.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Budgetarian.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Category> Categories { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
