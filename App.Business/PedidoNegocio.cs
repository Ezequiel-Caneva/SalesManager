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
        public Boolean AgregarFactura(Factura factura)
        {
            return _pedidoRepositorio.AgregarFactura(factura);
        }
        public Boolean AgregarFacturaPedido(Pedido pedido)
        {
            return _pedidoRepositorio.AgregarFacturaPedido(pedido);
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
    }
}
