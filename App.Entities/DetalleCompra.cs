using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("DETALLE_COMPRAS")]
    public class DetalleCompra
    {
        [Key]
        public string nombreproducto { set; get; }
        public int cantidad { set; get; }   
        public decimal preciocompra { set; get; }
        public int proveedorid { set; get; }
        public string proveedor { set; get; }
        public int productoid { set; get; }
        public string produto { set; get; }

    }
}
