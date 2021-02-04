using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UD24.Modelos
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) : base(options) { }
        public virtual DbSet<Fabricante> Fabricantes { get; set; }
        public virtual DbSet<Articulo> Articulos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fabricante>(e =>
            {
                e.HasKey(p => p.codigo);
                e.ToTable("Fabricantes");
/*int PK*/      e.Property(p => p.codigo).HasColumnName("CODIGO");
/*string*/      e.Property(p => p.nombre).IsRequired().HasMaxLength(100).IsUnicode(false);

                //e.HasMany(p => p.articulos).WithOne(p => p.fabricante).HasForeignKey(p => p.codigo).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_articulo_fabricante");
            });

            modelBuilder.Entity<Articulo>(e =>
            {
                e.HasKey(p => p.codigo);
                e.ToTable("Articulos");
/*int PK*/      e.Property(p => p.codigo).HasColumnName("CODIGO");
/*string*/      e.Property(p => p.nombre).IsRequired().HasMaxLength(100).IsUnicode(false);
/*int*/         e.Property(p => p.precio).IsRequired().HasColumnType("decimal(10, 2").IsUnicode(false);
/*int FK*/      e.Property(p => p.fabricanteId).IsRequired().IsUnicode(false);

                e.HasOne(p => p.Fabricante).WithMany(p => p.articulos).HasForeignKey(p => p.codigo);
            });
        }
    }
}
