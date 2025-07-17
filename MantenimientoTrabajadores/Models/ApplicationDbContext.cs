using Microsoft.EntityFrameworkCore;

namespace MantenimientoTrabajadores.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Trabajador> Trabajadores { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Distrito> Distritos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapear entidades a las tablas con nombres exactos
            modelBuilder.Entity<Departamento>().ToTable("Departamento");
            modelBuilder.Entity<Provincia>().ToTable("Provincia");
            modelBuilder.Entity<Distrito>().ToTable("Distrito");
            modelBuilder.Entity<Trabajador>().ToTable("Trabajadores");

            base.OnModelCreating(modelBuilder);
        }
    }
}
