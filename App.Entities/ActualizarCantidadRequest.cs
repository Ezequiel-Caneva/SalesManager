using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class ActualizarCantidadRequest
    {
        public int PedidoId { get; set; }
        public int ProductoId { get; set; }
        public int NuevaCantidad { get; set; }
    }
}
