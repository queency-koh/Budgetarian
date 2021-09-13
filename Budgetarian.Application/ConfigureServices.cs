using Budgetarian.Application.Categories.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Budgetarian.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services)
        {
            services.AddTransient<IGetCategoriesQuery, GetCategoriesQuery>();

            return services;
        }
    }
}
