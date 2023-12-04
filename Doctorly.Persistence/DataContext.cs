using Microsoft.EntityFrameworkCore;

namespace Doctorly.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=ASSET-10858;Database=Doctorly;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
        }

        public DbSet<Domain.Entities.Event>? Events { get; set; }


    }
}
