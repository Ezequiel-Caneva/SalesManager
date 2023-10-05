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

        public DbSet<Venta> Ventas { get; set; }

        //public MailsContext(DbContextOptions<MailContext> options) : base(options)
        //{
        //}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configura la cadena de conexión a la base de datos
            string connectionString = "Persist Security Info=True;Initial Catalog=PruebaMS;Data Source=.;Integrated Security=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
