using System.Data.Entity;
using Studies.models;

namespace Studies.context
{
    public class PhotographContext : DbContext
    {
        public DbSet<Photograph> Photographs { get; set; }
        public DbSet<PhotographFullImage> PhotographFullImages { get; set; }

        public PhotographContext() : base("name=PhotographContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Photograph>()
                .HasRequired(p => p.PhotographFullImage)
                .WithRequiredPrincipal(p => p.Photograph);

            modelBuilder.Entity<Photograph>()
                .ToTable("Photograph", "BazaDeDate");

            modelBuilder.Entity<PhotographFullImage>()
                .ToTable("Photograph", "BazaDeDate");
        }
    }
}