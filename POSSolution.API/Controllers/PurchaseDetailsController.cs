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
                    await _context.PurchaseDetails.AddAsync(entity);
                    int AffectedRow =  await _context.SaveChangesAsync();
                    if (AffectedRow != 0)
                    {
                        int QuantityToAdd = _context.PurchaseDetails.Where(w => w.Id == entity.Id).Select(s => s.Quantity).FirstOrDefault();
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
            catch (Exception ex)
            {

                //return StatusCode(StatusCodes.Status500InternalServerError,
                //    "Error creating new  record");
                throw new Exception(ex.Message);
            }
        }

        private async Task<Item> UpdateStock(int itemId)
        {
            Item item = await _context.Items.FindAsync(itemId);
            return item;
        }

    }
}
