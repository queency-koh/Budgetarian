using Budgetarian.Application.Categories.Queries;
using Budgetarian.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Budgetarian.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories([FromServices] IGetCategoriesQuery query)
        {
            return await query.Handle();
        }
    }
}
