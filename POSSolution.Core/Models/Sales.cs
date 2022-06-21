using POSSolution.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
    public class Sales : BaseModel
    {

        public List<SalesInvoice> SalesInvoices { get; private set; } = new List<SalesInvoice>();

    }

}
