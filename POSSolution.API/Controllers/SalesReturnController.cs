using Microsoft.AspNetCore.Mvc;
using POSSolution.Core.Models;
using POSSolution.Infrastructure;


namespace POSSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesReturnController : BaseController<Brand>
    {
        public SalesReturnController(POSContext context) : base(context)
        {

        }
    }
}
