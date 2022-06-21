using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POSSolution.Core.Models;
using POSSolution.Infrastructure;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace POSSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseDetailsController : BaseController<PurchaseDetails>
    {
        private POSContext _context;
        public PurchaseDetailsController(POSContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResult<PurchaseDetails>> CreateAsync([FromBody] PurchaseDetails entity)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    await _dbSet.AddAsync(entity);
                    int AffectedRow =  await _context.SaveChangesAsync();
                    if (AffectedRow != 0)
                    {
                        var QuantiyAmount = _dbSet.Select(s => s.Quantity);
                    }
                    return Ok(entity);
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new  record");
            }
        }

    }
}
