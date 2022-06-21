using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
   public class Country : BaseModel
    {
        public string Name { get; set; }
        public List<State>  States { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Supplier> Suppliers { get; set; }

    }
}
