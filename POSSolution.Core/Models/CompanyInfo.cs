using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
   public  class CompanyInfo: BaseModel
    {
        public string CompanyName { get; set; }

        [ForeignKey("State")]
        public int? StateId { get; set; }
        public State State { get; set; }

        [ForeignKey("City")]
        public int? CityId { get; set; }
        public City City { get; set; }

        public string Phone { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public string VATNumber { get; set; }
        public string TIN { get; set; }
        public string CompanyLogo { get; set; }
    }
}
