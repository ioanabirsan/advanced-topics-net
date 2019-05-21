using System.Data.Entity;
using DbContext = System.Data.Entity.DbContext;

namespace CarService
{
    public class CarServiceModelContainerMetadata : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<Client>()
                .HasIndex(c => c.Email)
                .IsUnique();
        }
    }
}