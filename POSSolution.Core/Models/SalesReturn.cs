using POSSolution.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
    public class SalesReturn : BaseModel
    {
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public SalesReturnStatus status { get; set; }
        public DateTime Date { get; set; }
        public decimal OtherCharges { get; set; }
        public decimal DsicountOnAll { get; set; }
        public string Note { get; set; }
        public decimal Amount { get; set; }
        public decimal PaymentType { get; set; }
        public decimal PaymentNote { get; set; }
    }
}
