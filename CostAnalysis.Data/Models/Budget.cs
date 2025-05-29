using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostAnalysis.Data.Models
{
    internal class Budget
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public decimal AllocatedAmount { get; set; }
    }
}
