using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("ENVIOS")]
    public class Envio
    {
        [Key]
        public int envioid { set; get; }
        public int codigoseguimiento { set; get; }  
        public DateTime fecha_envio { set; get; }
        public DateTime fecha_recepcion { set; get; }   
        public string empresa_transporte { set; get; }  
        public int pedido { set; get; }
      
    }
}
