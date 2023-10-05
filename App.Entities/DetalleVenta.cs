using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("DETALLE_VENTAS")]
    public class DetalleVenta
    {
        [Key]
        public int cantidad { set; get; }
        public decimal precio_total { set; get; }   
        public DateTime fecha { set; get; }
        public int pedido { set; get; } 
        public int producto { set; get; }

    }
}
