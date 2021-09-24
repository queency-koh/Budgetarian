using Budgetarian.Application.Common.Interfaces;
using Budgetarian.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Budgetarian.Application.Categories.Queries
{
    public class GetCategoriesQuery : IRequest<List<Category>>
    {
    }

    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, List<Category>>
    {
        private readonly IApplicationDbContext context;

        public GetCategoriesQueryHandler(IApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Category>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await context.Categories.ToListAsync(cancellationToken);
        }
    }
}
