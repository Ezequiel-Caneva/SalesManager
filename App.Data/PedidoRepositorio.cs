using App.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace App.Data
{
    public class PedidoRepositorio
    {
        private readonly Context _context;

        public PedidoRepositorio(Context context)
        {
            _context = context;
        }

        public Response<Pedido> MostrarPedidos(Search search)
        {
            var skipRows = ((search.PageIndex - 1) * search.PageSize);


            var query = _context.Pedido.Where(p => p.estado == search.TextToSearch);


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
             .Where(detalle => detalle.pedido == Convert.ToInt32(search.TextToSearch))
              .ToList();

            var count = query.Count();

            var query2 = _context.Producto.AsQueryable();
            var resultado = query.Select(detalle =>
            {
                var producto = query2.FirstOrDefault(p => p.productoid == detalle.producto);
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
        public Pedido ObtenerPedido(Search search)
        {
            var pedido = _context.Pedido.SingleOrDefault(p => p.pedidoid == Convert.ToInt32(search.TextToSearch));

            var detalles = _context.detalleVenta
            .Where(detalle => detalle.pedido == pedido.pedidoid)
             .ToList();
            var productos = _context.Producto.AsQueryable();

            var resultado = detalles.Select(detalle =>
            {
                var producto = productos.FirstOrDefault(p => p.productoid == detalle.producto);
                detalle._producto = producto;
                return detalle;
            }).ToList();

            pedido._venta = detalles;


            return pedido;
        }
        public Boolean AgregarFactura(Factura factura)
        {

            Boolean verificar = _context.Factura.Any(c => c.nrofactura == factura.nrofactura);

            if (verificar == true)
            {
                // El cliente ya existe, no lo agregues y devuelve falso para indicar que no se realizó la operación.
                return false;
            }
            else
            {
                // El cliente no existe, agrégalo a la base de datos y guarda los cambios.
                _context.Factura.Add(factura);
                _context.SaveChanges();
                return true;
            }
        }
        public bool AgregarFacturaPedido(Pedido pedido)
        {
          
             var pedidoExistente = _context.Pedido.FirstOrDefault(u => u.pedidoid == pedido.pedidoid);

            if (pedidoExistente != null)
                {
                pedidoExistente.factura = pedido.factura;
                pedidoExistente.estado = pedido.estado;
                foreach (var detalleventa in pedido._venta)
                    {
                        var productoEnBD = _context.Producto.FirstOrDefault(p => p.productoid == detalleventa.producto );

                        if (productoEnBD != null)
                        {
                            productoEnBD.stock -= detalleventa.cantidad;
                        }
                    }

                    // Actualiza los campos con los nuevos valores
                  

                    // Guarda los cambios en la base de datos una sola vez
                    _context.SaveChanges();

                    return true;
                }
            return false;


        }
        public Pedido ObtenerFactura(Search search)
        {
            var pedido = _context.Pedido.SingleOrDefault(p => p.pedidoid == Convert.ToInt32(search.TextToSearch));

            var detalles = _context.detalleVenta
            .Where(detalle => detalle.pedido == pedido.pedidoid)
             .ToList();
            var productos = _context.Producto.AsQueryable();
            pedido._factura = _context.Factura.SingleOrDefault(p => p.nrofactura == pedido.factura);
            var resultado = detalles.Select(detalle =>
            {
                var producto = productos.FirstOrDefault(p => p.productoid == detalle.producto);
                detalle._producto = producto;
                return detalle;
            }).ToList();

            pedido._venta = detalles;

            return pedido;
        }
    }
}


    

