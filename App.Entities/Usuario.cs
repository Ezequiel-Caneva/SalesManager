using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("USUARIOS")]
    public class Usuario
    {
        [Key]
        public int dni { get; set; }
        public string usuario { get; set; }
        public string contraseniahash { get; set; }
        public string contraseniasalt {  get; set; }
        public string email { get; set; }
        public int rol { get; set; }

    }
}
