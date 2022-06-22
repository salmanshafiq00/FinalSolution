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
    public class SalesDetailsController : BaseController<SalesDetails>
    {
        private POSContext _context;
        public SalesDetailsController(POSContext context) : base(context)
        {
            _context = context;
        }
        [NonAction]
        public override async Task<ActionResult<SalesDetails>> CreateAsync([FromBody] SalesDetails entity)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    await _context.SalesDetails.AddAsync(entity);
                    int AffectedRow = await _context.SaveChangesAsync();
                    if (AffectedRow != 0)
                    {
                        int QuantityToDispatch = _context.SalesDetails.Where(w => w.Id == entity.Id).Select(s => s.Quantity).FirstOrDefault();
                        int itemId = entity.ItemId;
                        Item itemForUpdate = await UpdateStock(itemId);
                        itemForUpdate.StockQuantity = itemForUpdate.StockQuantity - QuantityToDispatch;
                        _context.Items.Attach(itemForUpdate);
                        _context.Entry(itemForUpdate).Property(q => q.StockQuantity).IsModified = true;
                        _context.SaveChanges();

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

        private async Task<Item> UpdateStock(int itemId)
        {
            Item item = await _context.Items.FindAsync(itemId);
            return item;
        }
        [HttpPost]
        [Route("~/api/SalesDetails")]
        public async Task<ActionResult<SalesDetails>> CreateAsync([FromBody] SalesDetails[] entities)
        {
            foreach (SalesDetails entity in entities)
            {
                await CreateAsync(entity);
            }
            return Ok();
        }

    }
}

