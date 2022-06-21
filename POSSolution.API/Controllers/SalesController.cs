using Microsoft.AspNetCore.Mvc;
using POSSolution.Core.Models;
using POSSolution.Infrastructure;


namespace POSSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : BaseController<Brand>
    {
        public SalesController(POSContext context) : base(context)
        {

        }
    }
}
