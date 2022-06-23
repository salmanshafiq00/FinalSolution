using POSSolution.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
    public class SalesReturnInvoice : BaseModel
    {
        public string SalesReturnInvoiceNo { get; set; }
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("CompanyInfo")]
        public int CompanyInfoId { get; set; }
        public CompanyInfo Company { get; set; }
        public SalesReturnStatus Status { get; set; }
        public DateTime SalesReturnDate { get; set; }
        public int TotalQuantity { get; set; }
        public decimal SubTotal { get; set; }
        public decimal OtherCharges { get; set; }
        public decimal DiscountOnAll { get; set; }
        public decimal GrandTotal { get; set; }
        public string Note { get; set; }
        [ForeignKey("SalesInvoice")]
        public int SalesInvoiceId { get; set; }
        public SalesInvoice SalesInvoice { get; set; }
        public List<SalesReturnDetails> SalesReturnDetails { get; private set; } = new List<SalesReturnDetails>();
        public List<SalesPayment> SalesPayments { get; private set; } = new List<SalesPayment>();
    }
}
