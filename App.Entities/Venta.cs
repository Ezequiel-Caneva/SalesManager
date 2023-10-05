using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("Ventas")]
    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
      
    }
}
