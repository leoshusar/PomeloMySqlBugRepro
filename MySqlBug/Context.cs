using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySqlBug.Entities;
using MySqlBug.EntityTypeConfigurations;

namespace MySqlBug
{
    public class Context : DbContext
    {
        const string ConnString = "server=localhost;database=bug_test;user=root;password=secret";

        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnString, ServerVersion.AutoDetect(ConnString));
            optionsBuilder.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()));
        }

        public virtual DbSet<Rack> Racks { get; set; }
        public virtual DbSet<RackType> RackTypes { get; set; }
        public virtual DbSet<Shelf> Shelves { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RackEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RackTypeEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ShelfEntityTypeConfiguration());
        }
    }
}
