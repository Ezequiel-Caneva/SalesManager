using App.Data;
using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business
{
    public class PedidoNegocio
    {
        public PedidoRepositorio _pedidoRepositorio;


        public PedidoNegocio(PedidoRepositorio pedidoRepositorio)
        {
            _pedidoRepositorio = pedidoRepositorio;
        }

        public Response<Pedido> MostrarPedidos(Search search)
        {
            return _pedidoRepositorio.MostrarPedidos(search);
        }
        public Response<DetalleVenta> DetallePedido(Search search)
        {
            return _pedidoRepositorio.DetallePedido(search);
        }
        public Pedido ObtenerPedido(Search search)
        {
            return _pedidoRepositorio.ObtenerPedido(search);
        }
        public Boolean Confirmar(Pedido pedido)
        {
            return _pedidoRepositorio.Confirmar(pedido);
        }
        public Pedido ObtenerFactura(Search search)
        {
            return _pedidoRepositorio.ObtenerFactura(search);
        }
        public Boolean Rechazar(Pedido pedido)
        {
            return _pedidoRepositorio.Rechazar(pedido);
        }
        public Boolean EnvioNuevo(Envio envioNuevo)
        {
            return _pedidoRepositorio.EnvioNuevo(envioNuevo);
        }
        public Cliente DetalleCliente(Search search)
        {
            return _pedidoRepositorio.DetalleCliente(search);
        }
        public Envio DetalleEnvio(Search search)
        {
            return _pedidoRepositorio.DetalleEnvio(search);
        }
        public Boolean AgregarPedido(Pedido pedido)
        {
            return _pedidoRepositorio.AgregarPedido(pedido);

        }
        public Boolean AgregarPedido2(Pedido pedido)
        {
            return _pedidoRepositorio.AgregarPedido2(pedido);

        }
        public Response<Pedido> GetPedidosPorVendedor(Search search)
        {
            return _pedidoRepositorio.GetPedidosPorVendedor(search);
        }
        public async Task<bool> ActualizarCantidadProducto(int pedidoId, int productoId, int nuevaCantidad)
        {
            return await _pedidoRepositorio.ActualizarCantidadProducto(pedidoId, productoId, nuevaCantidad);
        }

        public async Task<bool> EliminarProductoDelPedido(int pedidoId, int productoId)
        {
            return await _pedidoRepositorio.EliminarProductoDelPedido(pedidoId, productoId);
        }

        public async Task<bool> ActualizarEstadoPedido(int pedidoId, string nuevoEstado)
        {
            return await _pedidoRepositorio.ActualizarEstadoPedido(pedidoId, nuevoEstado);
        }
    }
}
