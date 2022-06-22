using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
   public class SalesReturnDetails : BaseModel
    {
        public string ItemName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal UnitCost { get; set; }
        public decimal TotalAmount { get; set; }
        [ForeignKey("SalesReturnInvoice")]
        public int SalesReturnInvoiceId { get; set; }
        public SalesReturnInvoice SalesReturnInvoice { get; set; }

        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public Item Items { get; set; }
    }
}
