using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POSSolution.Core.Models
{
    public class Expense : BaseModel
    {
        public DateTime ExpenseDate { get; set; }

        [ForeignKey ("ExpenseCategory")]
        public int ExpenseCategoryId { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }
        public string ExpenseFor { get; set; }
        public decimal Ammount { get; set; }
        public string ReferenceNo { get; set; }
        public string Note { get; set; }
    }

}
