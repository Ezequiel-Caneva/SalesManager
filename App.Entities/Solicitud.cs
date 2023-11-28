using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("SOLICITUDES")]
    public class Solicitud
    {
        [Key]
        public int solicitudid {set; get; }
        public string nombre { set; get; }
        public string email { set; get; }
        public string telefono { set; get; }
        public string mensaje { set; get; }
        public string estado { set; get; }
    }
}
