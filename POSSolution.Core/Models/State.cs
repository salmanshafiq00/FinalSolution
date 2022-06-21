using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
   public class State : BaseModel
    {
        public string Name { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public List<City> Cities { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Supplier> Suppliers { get; set; }


    }
}
