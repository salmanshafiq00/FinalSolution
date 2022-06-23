using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
   public class PurchaseReturnDetails : BaseModel
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountAmount  { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal UnitCost { get; set; }
        public decimal TotalAmount { get; set; }
        [ForeignKey("PurchaseReturnInvoice")]
        public int PurchaseReturnInvoiceId { get; set; }
        public PurchaseReturnInvoice PurchaseReturnInvoice { get; set; }
        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public Item Items { get; set; }
    }
}
