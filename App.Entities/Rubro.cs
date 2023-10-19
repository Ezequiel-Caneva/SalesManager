using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("RUBROS")]
    public class Rubro
    {
        [Key]
        public int rubroid { get; set; }
        public string categoria { get; set; }
    }
}
