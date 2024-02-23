using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("PROMOCION")]
    public class Promocion
    {

        [Key]
        public int promocionid { get; set; }
        public int productoid { get; set; }
        public int descuento { get; set; }
        public decimal preciodescuento { get; set; }
        public Boolean estado { get; set; }
        public Producto? _producto { get; set; }
    }
}
