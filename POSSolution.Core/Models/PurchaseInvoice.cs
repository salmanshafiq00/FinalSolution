using POSSolution.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
    public class PurchaseInvoice : BaseModel
    {
        public string InvoiceNo { get; set; }
        [ForeignKey("CompanyInfo")]
        public int CompanyId { get; set; }
        public CompanyInfo Company { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime PurchaseDate { get; set; }
        public PurchaseStatus Status { get; set; }
        public string ReferencesNo { get; set; }
        public int TotalQuantity { get; set; }
        public decimal SubTotal { get; set; }
        public decimal OtherCharges { get; set; }
        public decimal DiscountOnAll { get; set; }
        public decimal GrandTotal { get; set; }
        public string Note { get; set; }

        public List<PurchaseDetails> PurchaseDetails { get; private set; } = new List<PurchaseDetails>();
        public List<PurchasePayment> PurchasePayment { get; private set; } = new List<PurchasePayment>();
    }
}
