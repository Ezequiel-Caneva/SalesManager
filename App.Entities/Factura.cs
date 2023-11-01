using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("FACTURAS")]
    public class Factura
    {
        [Key]
        public int nrofactura { get; set; }
        public DateTime fecha { get; set; } 
        public decimal montototal { get; set; }

        public bool? cobrado { get; set; }

    }
}
