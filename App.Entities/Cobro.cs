using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("PAGOS")]
    public class Cobro
    {
        public DateTime fecha { get; set; }
        [Key]
        public int pagoid { get; set; }
        public int? nrofactura { get; set; }
        
        public int? cliente { get; set; }
        public string tipo_comprobante { get; set; }
        
        public int nro_comprobante { get;set; }
        public string? metodopago { get; set; }
        public decimal debito { get; set; }
        public decimal? credito { get; set; }
        public decimal? saldo { get; set; }

        public Factura? _factura { get; set; }   
        public Cliente? _cliente {  get; set; }  
   
    }
}
