using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class ActualizarEstadoRequest
    {
        public int PedidoId { get; set; }
        public string NuevoEstado { get; set; }
    }
}
