using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
   public class Brand : BaseModel
    {
        public string Name { get; set; }
        public string Desciption { get; set; }
        public List<Item> Items { get; set; }
    }
}
