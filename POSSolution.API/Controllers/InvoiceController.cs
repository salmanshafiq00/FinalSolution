using Microsoft.AspNetCore.Mvc;
using POSSolution.Core.Models;
using POSSolution.Infrastructure;


namespace POSSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : BaseController<Brand>
    {
        public InvoiceController(POSContext context) : base(context)
        {

        }
    }
}

