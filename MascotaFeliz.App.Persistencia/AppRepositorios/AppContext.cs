using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        public DbSet<Veterinario> Veterinarios { get; set; }

        public DbSet<Dueno> Duenos { get; set; }

        public DbSet<VisitaPyP> VisitasPyP { get; set; }

        public DbSet<Historia> Historias { get; set; }

        public DbSet<Mascota> Mascotas { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder
        )
        {
            if (!optionsBuilder.IsConfigured)
            {
                // optionsBuilder
                //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MascotaFelizData");
                optionsBuilder
                    .UseSqlServer("Data Source = leosuarez.mssql.somee.com; Initial Catalog = leosuarez;user id=leosuarez16_SQLLogin_1;pwd=vj2mklnzqx");
            }
        }
    }
}
