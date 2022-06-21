using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
   public class SalesDetails : BaseModel
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
        [ForeignKey("SalesInvoice")]
        public int SalesInvoiceId { get; set; }
        public SalesInvoice SalesInvoice { get; set; }
    }
}
