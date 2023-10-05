using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("PERMISOS")]
    public class Permiso
    {
        public int permisoid { get; set; }
        public string nombremenu { get; set; }
        public int rol {  get; set; }

    }
}
