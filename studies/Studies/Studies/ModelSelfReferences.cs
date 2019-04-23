using Studies.models;

namespace Studies
{
    using System.Data.Entity;

    public class ModelSelfReferences : DbContext
    {
        // Your context has been configured to use a 'ModelSelfReferences' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Studies.ModelSelfReferences' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelSelfReferences' 
        // connection string in the application configuration file.
        public ModelSelfReferences()
            : base("name=ModelSelfReferences")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SelfReference>()
                .HasMany(m => m.References)
                .WithOptional(m => m.ParentSelfReference);

            modelBuilder.Entity<SelfReference>()
                .Property(c => c.Name)
                .IsRequired().HasMaxLength(100);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<SelfReference> SelfReferences { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}