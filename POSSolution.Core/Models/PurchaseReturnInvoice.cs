using POSSolution.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
    public class PurchaseReturnInvoice : BaseModel
    {
        public string ReturnInvoiceNo { get; set; }
        [ForeignKey("CompanyInfo")]
        public int CompanyId { get; set; }
        public CompanyInfo Company { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime PurchaseReturnDate { get; set; }
        public PurchaseReturnStatus Status { get; set; }
        public string ReferencesNo { get; set; }
        public int TotalQuantity { get; set; }
        public decimal SubTotal { get; set; }
        public decimal OtherCharges { get; set; }
        public decimal DiscountOnAll { get; set; }
        public decimal GrandTotal { get; set; }
        public string Note { get; set; }
        [ForeignKey("PurchaseInvoice")]
        public int? PurchaseId { get; set; }
        public PurchaseInvoice PurchaseInvoice { get; set; }
        public List<PurchaseReturnDetails> PurchaseDetails { get; private set; } = new List<PurchaseReturnDetails>();
        public List<PurchasePayment> PurchasePayment { get; private set; } = new List<PurchasePayment>();
    }
}
