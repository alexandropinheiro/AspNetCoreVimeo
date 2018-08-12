using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StartupDemo.Models;
using System.IO;

namespace DemoEFCore.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base()
        {

        }

        public DbSet<Evento> Eventos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evento>()
                .Property(c => c.Id)
                .HasColumnName("EventoId");

            modelBuilder.Entity<Evento>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Evento>()
                .Property(c => c.Descricao)
                .HasColumnType("varchar(500)")
                .HasMaxLength(500);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=MYDB;Integrated     Security=True;MultipleActiveResultSets=True;");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
