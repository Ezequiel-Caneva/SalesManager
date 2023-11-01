using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("PRODUCTOS")]
    public class Producto
    {
        [Key]
        public int productoid { get; set; } 
        public string nombre { get; set; }  
        public int codigobarra { get; set; } 
        public decimal precioventa {  get; set; }
        public int stock { get; set; }
        public int rubro { get; set; }
        public Rubro _Rubro { get; set; }    

    }
}
