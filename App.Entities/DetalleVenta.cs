using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("DETALLE_VENTAS")]
    public class DetalleVenta
    {
        [Key]
        public int pedido { set; get; }

        [Key]
        public int producto { get; set; }
        public int cantidad { set; get; }
   
        public decimal precio_total { set; get; }
        public DateTime? fecha { set; get; }

      
        public Producto? _producto { set; get; } = null;

        
       
    }
}
       
