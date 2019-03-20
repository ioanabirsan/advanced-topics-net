using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CarService.Context
{
    public class CarServiceModelContainerMetadata : DbContext
    {
        public CarServiceModelContainerMetadata()
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Models.Client.Client> Clienti { get; set; }
        public virtual DbSet<Models.Auto.Auto> Automobile { get; set; }
        public virtual DbSet<Models.Sasiu.Sasiu> Sasiuri { get; set; }
        public virtual DbSet<Models.Mecanic.Mecanic> Mecanici { get; set; }
        public virtual DbSet<Models.Material.Material> Materiale { get; set; }
        public virtual DbSet<Models.Imagine.Imagine> Imagini { get; set; }
        public virtual DbSet<Models.Operatie.Operatie> Operatii { get; set; }
        public virtual DbSet<Models.Comanda.Comanda> Comenzi { get; set; }
        public virtual DbSet<Models.DetaliuComanda.DetaliuComanda> DetaliiComenzi { get; set; }
    }
}
