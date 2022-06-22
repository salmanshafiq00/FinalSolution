using POSSolution.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
   public class SalesInvoice : BaseModel
    {
        public string SalesInvoiceNo { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("CompanyInfo")]
        public int CompanyInfoId { get; set; }
        public CompanyInfo Company { get; set; }
        public SalesStatus Status { get; set; }
        public DateTime SalesDate { get; set; }
        public int TotalQuantity { get; set; }
        public decimal SubTotal { get; set; }
        public decimal OtherCharges { get; set; }
        public decimal DiscountOnAll { get; set; }
        public decimal GrandTotal { get; set; }
        public string Note { get; set; }
        public List<SalesDetails> SalesDetails { get; private set; } = new List<SalesDetails>();
        public List<SalesPayment> SalesPayments { get; private set; } = new List<SalesPayment>();

    }
}
