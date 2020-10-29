namespace Lab04.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FilterDbContext : DbContext
    {
        public FilterDbContext()
            : base("name=FilterDbContext")
        {
        }

        public virtual DbSet<laptop> laptops { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
