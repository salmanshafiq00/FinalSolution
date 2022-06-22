using System.ComponentModel.DataAnnotations.Schema;

namespace POSSolution.Core.Models
{
    public class Customer : BaseModel
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int  Mobile { get; set; }
        public string TAXNumber { get; set; }
        public decimal OpeningBlanace { get; set; }

        [ForeignKey("Country")]
        public int? CountryId { get; set; }
        public Country Country { get; set; }

        [ForeignKey("State")]
        public int? StateId { get; set; }
        public State State { get; set; }

        [ForeignKey("City")]
        public int? CityId { get; set; }
        public City City { get; set; }
        public string PostCode { get; set; }        
        public string Address { get; set; }

    }
}
