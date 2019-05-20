using System.Data.Entity;

namespace Studies
{
    public class Model1ContainerMetadata
    {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerEmail> CustomerEmails { get; set; }
        public virtual DbSet<CustomerType> CustomerTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
    }
}