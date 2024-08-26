using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App.Business;
using App.Entities;
using App.Data;

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
        [HttpPost("MostrarPedidos")]
        public Response<Pedido> MostrarPedidos(Search search)
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
        [HttpPost("ObtenerFactura")]
        public Pedido ObtenerFactura(Search search)
        {
            return _pedidoNegocio.ObtenerFactura(search);
        }
        [HttpPost("Rechazado")]
        public Boolean Rechazar(Pedido pedido)
        {
            return _pedidoNegocio.Rechazar(pedido);
        }
        [HttpPost("Confirmado")]
        public Boolean Confirmar(Pedido pedido)
        {
            return _pedidoNegocio.Confirmar(pedido);
        }
        [HttpPost("Despachado")]
        public Boolean Despachar(Pedido pedido)
        {
            return _pedidoNegocio.Rechazar(pedido);
        }
        [HttpPost("EnvioNuevo")]
        public Boolean EnvioNuevo(Envio envioNuevo)
        {
            return _pedidoNegocio.EnvioNuevo(envioNuevo);
        }
        [HttpPost("DetalleCliente")]
        public Cliente DetalleCliente(Search search)
        {
            return _pedidoNegocio.DetalleCliente(search);
        }
        [HttpPost("DetalleEnvio")]
        public Envio DetalleEnvio(Search search)
        {
            return _pedidoNegocio.DetalleEnvio(search);
        }
        [HttpPost("AgregarPedido")]
        public Boolean AgregarPedido(Pedido pedido)
        {
            return _pedidoNegocio.AgregarPedido(pedido);
        }
        [HttpPost("AgregarPedido2")]
        public Boolean AgregarPedio2(Pedido pedido)
        {
            return _pedidoNegocio.AgregarPedido2(pedido);
        }
        [HttpPost("GetPedidosPorVendedor")]
        public Response<Pedido> GetPedidosPorVendedor(Search search)
        {
            return _pedidoNegocio.GetPedidosPorVendedor(search);
        }
        // Nuevo endpoint para eliminar producto del pedido
        [HttpPost("EliminarProductoDelPedido")]
        public async Task<IActionResult> EliminarProductoDelPedido([FromBody] EliminarProductoRequest request)
        {
            var result = await _pedidoNegocio.EliminarProductoDelPedido(request.PedidoId, request.ProductoId);
            return Ok(result);
        }

        [HttpPost("ActualizarEstadoPedido")]
        public async Task<IActionResult> ActualizarEstadoPedido([FromBody] ActualizarEstadoRequest request)
        {
            var result = await _pedidoNegocio.ActualizarEstadoPedido(request.PedidoId, request.NuevoEstado);
            return Ok(result);
        }

        [HttpPut("ActualizarCantidadProducto")]
        public async Task<IActionResult> ActualizarCantidadProducto([FromBody] ActualizarCantidadRequest request)
        {
            var result = await _pedidoNegocio.ActualizarCantidadProducto(request.PedidoId, request.ProductoId, request.NuevaCantidad);
            return Ok(result);
        }
    }
}