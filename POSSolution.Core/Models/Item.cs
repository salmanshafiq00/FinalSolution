using POSSolution.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
  public  class Item : BaseModel
    {
        public string Name { get; set; }
        public string ItemCode { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [ForeignKey("Unit")]
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public string SKU { get; set; }
        public decimal MinimumQty { get; set; }
        public int LotNumber { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int StockQuantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public Decimal Tax { get; set; }
        public TaxType TaxType { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal FinalPrice { get; set; }

    }
}
