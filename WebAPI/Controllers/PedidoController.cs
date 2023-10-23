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
            return _pedidoNegocio.MostrarPedidos(search);
        }
        [HttpPost("DetallePedido")]
        public Response<DetalleVenta> DetallePedido(Search search)
        {
            return _pedidoNegocio.DetallePedido(search);
        }
        [HttpPost("ObtenerPedido")]
        public Pedido ObtenerPedido(Search search)
        {
            return _pedidoNegocio.ObtenerPedido(search);
        }
        [HttpPost("AgregarFactura")]
        public Boolean AgregarFactura(Factura factura)
        {
            return _pedidoNegocio.AgregarFactura(factura);
        }
        [HttpPost("Confirmar")]
        public Boolean AgregarFacturaPedido(Pedido pedido)
        {
            return _pedidoNegocio.AgregarFacturaPedido(pedido);
        }
        [HttpPost("ObtenerFactura")]
        public Pedido ObtenerFactura(Search search)
        {
            return _pedidoNegocio.ObtenerFactura(search);
        }
        [HttpPost("Rechazar")] 
        public Boolean Rechazar(Pedido pedido)
        {
            return _pedidoNegocio.Rechazar(pedido);
        }
        [HttpPost("EnvioNuevo")]
        public Boolean EnvioNuevo(Envio envioNuevo) 
        {
            return _pedidoNegocio.EnvioNuevo(envioNuevo);
        }
    }
}
