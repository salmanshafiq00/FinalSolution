using Microsoft.AspNetCore.Mvc;
using POSSolution.Core.Models;
using POSSolution.Infrastructure;

namespace POSSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : BaseController<Purchase>
    {

        public PurchaseController(POSContext context) : base(context)
        {

        }

    }
}
