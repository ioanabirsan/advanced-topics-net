using System.Data.Entity;
using Studies.models;

namespace Studies.context
{
    public class BusinessContext : DbContext
    {
        public DbSet<Business> Businesses { get; set; }

        public BusinessContext() : base("name=BusinessContext")
        {
        }

    }
}
