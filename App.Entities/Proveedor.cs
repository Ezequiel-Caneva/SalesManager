using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("PROVEEDORES")]
    public class Proveedor
    {
        [Key]
        public int proveedorid { get; set; }
        public string razonsocial { get; set; }
        public string nombre { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }   
        public Proveedor() { }

    }
}
