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
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Promocion> Promocion { get; set; }
        public DbSet<Solicitud> Solicutud { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configura la cadena de conexión a la base de datos
            string connectionString = "Persist Security Info=True;Initial Catalog=MOTO_PARTES_EXPRESS;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";
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
            modelBuilder.Entity<DetalleVenta>()
                .HasOne(p => p._producto)
                .WithMany()
                .HasForeignKey(p => p.producto);
            modelBuilder.Entity<Pedido>()
                 .HasOne(p => p._factura)
                .WithMany()
                .HasForeignKey(p => p.factura);
            modelBuilder.Entity<Pedido>()
                 .HasOne(p => p._cliente)
                .WithMany()
                .HasForeignKey(p => p.cliente);
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p._vendedor)
               .WithMany()
               .HasForeignKey(p => p.vendedor);
            modelBuilder.Entity<Cobro>()
                 .HasOne(p => p._cliente)
                .WithMany()
                .HasForeignKey(p => p.cliente);
            modelBuilder.Entity<Cobro>()
                .HasOne(p => p._factura)
               .WithMany()
               .HasForeignKey(p => p.nrofactura);
            modelBuilder.Entity<Vendedor>()
               .HasOne(p => p.usuario)
              .WithMany()
              .HasForeignKey(p => p.usuarioid);
            modelBuilder.Entity<DetalleVenta>()
            .HasOne(p => p._pedido)
           .WithMany()
           .HasForeignKey(p => p.pedido);
            modelBuilder.Entity<Promocion>()
            .HasOne(p => p._producto)
           .WithMany()
           .HasForeignKey(p => p.productoid);
            modelBuilder.Entity<Envio>()
      


        }

    }
}
