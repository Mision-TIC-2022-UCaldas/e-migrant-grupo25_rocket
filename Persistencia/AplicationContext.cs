using Microsoft.EntityFrameworkCore;
using Dominio;
namespace Persistencia
{
    public class AplicationContext : DbContext
    {
        public DbSet<Migrante> migrante {get; set;} 
        public DbSet<Entidad> entidad {get; set;}               
        public DbSet<Servicio> servicio {get; set;}               
        private const string connectionString = @"Data Source=tcp:equiporocket.database.windows.net,1433;Initial Catalog=RocketDB;Persist Security Info=False;User ID=admijessie;Password=Teamrocket1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public AplicationContext()
        {
        }
        public AplicationContext(DbContextOptions<AplicationContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                if (!optionsBuilder.IsConfigured)
                {
                        optionsBuilder
                        .UseSqlServer(connectionString);
                }
        }
        
    }
}