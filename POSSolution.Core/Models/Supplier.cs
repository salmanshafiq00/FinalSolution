using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
    public class Supplier : BaseModel
    {
        public string Name { get; set; }
        public int Mobile { get; set; }
        public int  Phone { get; set; }
        public string Email { get; set; }
        public string TaxNumber { get; set; }
        public decimal OpeningBalance { get; set; }
        [ForeignKey("Country")]
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        [ForeignKey("State")]
        public int StateId { get; set; }
        public State State { get; set; }
        [ForeignKey("City")]
        public int? CityId { get; set; }
        public City City { get; set; }
        public string Postcode { get; set; }
        public string  Address { get; set; }
        public List<Purchase> Purchases { get; set; }
    }
}
