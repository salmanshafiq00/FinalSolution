using POSSolution.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
    public class SalesPayment : BaseModel
    {
        public PaymentType PaymentType { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public decimal DueAmount { get; set; }
        [ForeignKey("SalesInvoice")]
        public int SalesInvoiceId { get; set; }
        public SalesInvoice SalesInvoice { get; set; }
    }
}
