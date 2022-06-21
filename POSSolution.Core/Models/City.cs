using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
    public   class City : BaseModel
    {
        public string Name { get; set; }
        [ForeignKey("State")]
        public int StateId { get; set; }
        public State State { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Supplier> Suppliers { get; set; }


    }
}
