using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("ROLES")]
    public class Rol
    {
        [Key]
        public int rolid { get; set; }
        public string nombre { get; set; }
        
    }
}
