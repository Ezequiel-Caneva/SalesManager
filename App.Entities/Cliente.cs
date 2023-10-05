using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("CLIENTES")]
    public class Cliente
    {
        [Key]
        public int clienteid { set; get; }
        public int dni { set; get; }
        public string nombre { set; get; }
        public string direccion { set; get; }
        public int telefono { set; get; }
        public string email { set; get; }
        public string ciudad { set; get; }
        public int codigopostal { set; get; }

        Cliente() { }
    }
}
