namespace TreeBased.UI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TestDBModel : DbContext
    {
        public TestDBModel()
            : base("name=TestDBModel")
        {
        }

        public virtual DbSet<Job> Jobs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>()
                .Property(e => e.CodeYegan)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.CodeYeganNum)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.CodeJob)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.TitlePost)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.KeyPost)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.JobID)
                .IsUnicode(false);
        }
    }
}
