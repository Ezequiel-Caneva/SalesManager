using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App.Business;
using App.Entities;

namespace WebAPI.Controllers
{
    [Route("api/Pedido")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        public PedidoNegocio _pedidoNegocio;
        public PedidoController(PedidoNegocio pedidoNegocio)
        {
            _pedidoNegocio = pedidoNegocio;
        }
        [HttpPost("MostrarPendientes")]
        public Response<Pedido> MostrarPendientes(Search search)
        {
            return _pedidoNegocio.MostrarPendientes(search);
        }
        [HttpPost("DetallePedido")]
        public Response<DetalleVenta> DetallePedido(Search search)
        {
            return _pedidoNegocio.DetallePedido(search);
        }

    }
}
