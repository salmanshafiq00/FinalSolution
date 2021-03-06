using Microsoft.AspNetCore.Mvc;
using POSSolution.Core.Models;
using POSSolution.Infrastructure;


namespace POSSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : BaseController<Item>
    {
        public ItemController(POSContext context) : base(context)
        {

        }
    }
}
