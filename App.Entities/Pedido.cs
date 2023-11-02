using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("PEDIDOS")]
    public class Pedido
    {
        [Key]
        public int pedidoid { get; set; } 
        public string estado { get; set; }
        public DateTime? fecha { get; set; }   
        public int? factura { get; set; }    
        public int? vendedor { get; set; }   
        public int? cliente { get; set; }
        [NotMapped]
        public List<DetalleVenta>? _venta {  get; set; } 
        [NotMapped]
        public Factura? _factura { get; set; }
        [NotMapped]
        public Cliente? _cliente {  get; set; }



    }
}
