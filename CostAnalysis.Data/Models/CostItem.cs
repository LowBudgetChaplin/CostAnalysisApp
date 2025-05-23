using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CostAnalysis.Data.Models
{
    public class CostItem
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateIncurred { get; set; }
        public virtual CostCategory? Category { get; set; }
    }
}
