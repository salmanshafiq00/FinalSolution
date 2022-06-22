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
    public class SalesReturnDetailsController : BaseController<SalesReturnDetails>
    {
        private POSContext _context;
        public SalesReturnDetailsController(POSContext context) : base(context)
        {
            _context = context;
        }
        [NonAction]
        public override async Task<ActionResult<SalesReturnDetails>> CreateAsync([FromBody] SalesReturnDetails entity)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    await _context.SalesReturnDetails.AddAsync(entity);
                    int AffectedRow = await _context.SaveChangesAsync();
                    if (AffectedRow != 0)
                    {
                        int QuantityToAdd = _context.SalesReturnDetails.Where(w => w.Id == entity.Id).Select(s => s.Quantity).FirstOrDefault();
                        int itemId = entity.ItemId;
                        Item itemForUpdate = await UpdateStock(itemId);
                        itemForUpdate.StockQuantity = itemForUpdate.StockQuantity + QuantityToAdd;
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
        [Route("~/api/SalesReturnDetails")]
        public async Task<ActionResult<SalesReturnDetails>> CreateAsync([FromBody] SalesReturnDetails[] entities)
        {
            foreach (SalesReturnDetails entity in entities)
            {
                await CreateAsync(entity);
            }
            return Ok();
        }

    }
}
