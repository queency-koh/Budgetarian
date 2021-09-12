using Budgetarian.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Budgetarian.Infrastructure.Persistence.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.Property(t => t.Title)
                .HasMaxLength(280)
                .IsRequired();

            builder.Property(t => t.Notes)
                .HasMaxLength(4000);
        }
    }
}
