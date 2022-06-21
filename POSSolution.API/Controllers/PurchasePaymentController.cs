using Microsoft.AspNetCore.Mvc;
using POSSolution.Core.Models;
using POSSolution.Infrastructure;

namespace POSSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasePaymentController : BaseController<PurchasePayment>
    {

        public PurchasePaymentController(POSContext context) : base(context)
        {

        }

    }
}
