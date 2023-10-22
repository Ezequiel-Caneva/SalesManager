using App.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class PedidoRepositorio
    {
        private readonly Context _context;

        public PedidoRepositorio(Context context)
        {
            _context = context;
        }
    
        public Response<Pedido> MostrarPendientes(Search search)
        {
            var skipRows = ((search.PageIndex - 1) * search.PageSize);


            var query = _context.Pedido.AsQueryable();


            var count = query.Count();

            var response = new Response<Pedido>()
            {
                Items = query.Skip(skipRows)
                             .Take(search.PageSize)
                             .ToList(),
                Total = count
            };

            return response;
        }
        public Response<DetalleVenta> DetallePedido(Search search)
        {
            var skipRows = ((search.PageIndex - 1) * search.PageSize);

            var query = _context.detalleVenta
             .Where(detalle => detalle.pedido== Convert.ToInt32(search.TextToSearch))
              .ToList();

            var count = query.Count();

            var query2 = _context.Producto.AsQueryable();
            var resultado = query.Select(detalle =>
            {
                var producto = query2.FirstOrDefault(p => p.productoid == detalle.pedido);
                detalle._producto = producto;
                return detalle;
            }).ToList();

            var response = new Response<DetalleVenta>()
            {
                Items = query.Skip(skipRows)
                             .Take(search.PageSize)
                             .ToList(),
                Total = count
            };
            return response;

        }
        public Response<DetalleVenta> ObtenerStock(Search search)
        {

            return null;
        

        }
    }
}
