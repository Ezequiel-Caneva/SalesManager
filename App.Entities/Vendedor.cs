using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("VENDEDORES")]
    public class Vendedor
    {
        [Key]
        public int vendedorid { get; set; }
        public string zona {  get; set; }
        public int usuarioid { get; set; }
        public Usuario? usuario{ get; set; }
    }
}
