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
       
        public Response<Pedido> MostrarPendientes(Search search)
        {
            return _pedidoRepositorio.MostrarPendientes(search);
        }
        public Response<DetalleVenta> DetallePedido(Search search)
        {
            return _pedidoRepositorio.DetallePedido(search);
        }
    }
}
