using System.Data.Entity;

namespace Studies.context
{
    public class ProductContext : DbContext
    {
        public DbSet<models.Product> Products { get; set; }

        public ProductContext() : base("name=ProductContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<models.Product>()
                .Map(m =>
                {
                    m.Properties(p => new {p.SKU, p.Description, p.Price});
                    m.ToTable("Product", "BazaDeDate");
                })
                .Map(m =>
                {
                    m.Properties(p => new {p.SKU, p.ImageUrl});
                    m.ToTable("ProductWebInfo", "BazaDeDate");
                });
        }
    }
}