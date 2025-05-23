using System.Collections.Generic;

namespace CostAnalysis.Data.Models
{
    public class CostCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<CostItem>? Items { get; set; }
    }
}