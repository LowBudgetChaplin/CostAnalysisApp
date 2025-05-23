using System.Data.Entity;
using CostAnalysis.Data.Models;

namespace CostAnalysis.Data
{
    public class CostAnalysisContext : DbContext
    {
        public CostAnalysisContext() 
            : base("name=CostAnalysisDb")
        { }

        public DbSet<CostCategory> Categories { get; set; }
        public DbSet<CostItem>     Items      { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CostCategory>()
                        .HasMany(c => c.Items)
                        .WithRequired(i => i.Category)
                        .HasForeignKey(i => i.CategoryId);
        }
    }
}