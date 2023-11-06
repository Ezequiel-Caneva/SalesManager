using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("COMPROBANTES")]
    public class Comprobante
    {
        [Key]
        public int nro_comprobante {set; get; }
        public int pago {set; get; }
    
    }
}
