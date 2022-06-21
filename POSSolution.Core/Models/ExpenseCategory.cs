using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
    public class ExpenseCategory : BaseModel
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Expense> Expenses { get; set; }
    }
}
