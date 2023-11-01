using App.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{

    public class Context : DbContext
    {

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Rubro> Rubro { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<DetalleCompra> Compra { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<DetalleVenta> detalleVenta { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Envio> Envio { get; set; }
        public DbSet<Cobro> Cobro { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configura la cadena de conexión a la base de datos
            string connectionString = "Persist Security Info=True;Initial Catalog=MOTO_PARTES_EXPRESS;Data Source=.;Integrated Security=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .HasOne(p => p._Rubro)
                .WithMany()
                .HasForeignKey(p => p.rubro);
            modelBuilder.Entity<DetalleVenta>()
            .HasKey(d => new { d.pedido, d.producto });
        }

    }
}
