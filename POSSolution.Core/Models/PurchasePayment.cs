using POSSolution.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
    public class PurchasePayment : BaseModel
    {
        public PaymentType PaymentType { get; set; }
        public DateTime PaymentDate { get; set; }
        public Decimal Amount { get; set; }
        public decimal DueAmount { get; set; }
        public string PaymentNote { get; set; }
        [ForeignKey("PurchaseInvoice")]
        public int PurchaseInvoiceId { get; set; }
        public PurchaseInvoice PurchaseInvoice { get; set; }
    }
}
