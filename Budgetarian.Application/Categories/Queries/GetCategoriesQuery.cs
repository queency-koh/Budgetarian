using Budgetarian.Application.Common.Interfaces;
using Budgetarian.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Budgetarian.Application.Categories.Queries
{
    public interface IGetCategoriesQuery
    {
        Task<List<Category>> Handle();
    }

    public class GetCategoriesQuery : IGetCategoriesQuery
    {
        private readonly IApplicationDbContext context;

        public GetCategoriesQuery(IApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Category>> Handle()
        {
            return await context.Categories.ToListAsync();
        }
    }
}
