using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POSSolution.Core.Models;
using POSSolution.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesReturnInvoiceController : BaseController<SalesReturnInvoice>
    {
        private POSContext _context;
        public SalesReturnInvoiceController(POSContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<ActionResult<IEnumerable<SalesReturnInvoice>>> GetAllAsync()
        {
            try
            {
                return Ok(await _context.SalesReturnInvoices
                    .Include("SalesReturnDetails").ToListAsync());


            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                  "Error retrieving data from the database");
            }
        }
    }
}


