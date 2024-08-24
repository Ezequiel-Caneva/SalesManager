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


            var query = _context.Pedido.Where(p => p.estado == search.TextToSearch || p.estado == search.TextToSearch2).
               
                Include(detalle => detalle._cliente).
                Include(detalle => detalle._factura);



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
              .Include(detalle => detalle._producto)
              .ToList();

            var count = query.Count();

            var response = new Response<DetalleVenta>()
            {
                Items = query.Skip(skipRows)
                             .Take(search.PageSize)
                             .ToList(),
                Total = count
            };
            return response;
        }
    
        public Pedido ObtenerPedido(Search search)
        {
            var pedido = _context.Pedido
                     .Include(p => p._factura)
                     .Include(p=>p._cliente)
                     .SingleOrDefault(p => p.pedidoid == Convert.ToInt32(search.TextToSearch));
            var detalles = _context.detalleVenta
             .Where(detalle => detalle.pedido == pedido.pedidoid)
              .Include(detalle => detalle._producto)
              .ToList();
            pedido._venta = detalles;
            return pedido;
        }
     
        public Boolean Confirmar(Pedido pedido)
        {

            var pedidoExistente = _context.Pedido.FirstOrDefault(u => u.pedidoid == pedido.pedidoid);

            if (pedidoExistente != null)
            {
                pedidoExistente.factura = pedido.factura;
                pedidoExistente.estado = pedido.estado;
                var detalle_venta = _context.detalleVenta.Where(d => d.pedido == pedido.pedidoid).ToList();

                foreach (var detalleventa in detalle_venta)
                {
                    var productoEnBD = _context.Producto.FirstOrDefault(p => p.productoid == detalleventa.producto);

                    if (productoEnBD != null)
                    {
                        productoEnBD.stock -= detalleventa.cantidad;
                    }
                    
                }
                Boolean verificar = _context.Factura.Any(c => c.nrofactura == pedido._factura.nrofactura);
                if (verificar == true)
                {
                    return false;
                }
                else
                {
                    //Agregar factura en cobros
                    Cobro cobro = new Cobro()
                    {
                        nrofactura = pedido.factura,
                        cliente = pedido.cliente,
                        fecha = DateTime.Now,
                        tipo_comprobante = "FAC",
                        debito = pedido._factura.montototal,
                        saldo = pedido._factura.montototal,
                        nro_comprobante = pedido._factura.nrofactura
                    };
                    Factura factura = new Factura();
                    factura = pedido._factura;
                    _context.Cobro.Add(cobro);
                    //Agregar factura en Facturas
                    _context.Factura.Add(factura);
                    _context.SaveChanges();
                    return true;
                }
               
            }
            return false;
        }
        public Boolean Rechazar(Pedido pedido)
        {

            bool verificar = _context.Pedido.Any(c => c.pedidoid == pedido.pedidoid);
            if (verificar == true)
            {
                var pedidoidExistente = _context.Pedido.Find(pedido.pedidoid);

                if (pedidoidExistente != null)
                {

                    // Actualiza los campos con los nuevos valores
                    pedidoidExistente.estado = pedido.estado;

                    // Guarda los cambios en la base de datos
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
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
        public Boolean EnvioNuevo(Envio envioNuevo)
        {
            _context.Envio.Add(envioNuevo);
            _context.SaveChanges();
            return true;
        }
        public Cliente DetalleCliente(Search search)
        {
            var pedido = _context.Pedido.FirstOrDefault(u => u.pedidoid == Convert.ToInt32(search.TextToSearch));
            var cliente = _context.Cliente.FirstOrDefault(r => r.clienteid == pedido.cliente);
            return cliente;
        }
        public Envio DetalleEnvio(Search search)
        {
            var envio= _context.Envio.FirstOrDefault(u => u.pedido == Convert.ToInt32(search.TextToSearch));
            return envio;
        }
        public Boolean AgregarPedido(Pedido pedido)
        {
        
                _context.Pedido.Add(pedido);
                _context.Factura.Add(pedido._factura);
                _context.SaveChanges();

                int pedidoidGenerado = pedido.pedidoid;
                foreach (var detalleventa in pedido._venta)
                {
                    detalleventa.pedido = pedidoidGenerado;
                     detalleventa._producto = null;
                    _context.detalleVenta.Add(detalleventa);

                }
                
                foreach (var detalleventa in pedido._venta)
                {
                    var producto = _context.Producto.FirstOrDefault(u => u.productoid == detalleventa.producto);
                     producto.stock = producto.stock - detalleventa.cantidad;
                }
                _context.SaveChanges();

                return true;

        }
        public Boolean AgregarPedido2(Pedido pedido)
        {

            _context.Pedido.Add(pedido);         
            _context.SaveChanges();

            int pedidoidGenerado = pedido.pedidoid;
            foreach (var detalleventa in pedido._venta)
            {
                detalleventa.pedido = pedidoidGenerado;
                detalleventa._producto = null;
                _context.detalleVenta.Add(detalleventa);

            }

            foreach (var detalleventa in pedido._venta)
            {
                var producto = _context.Producto.FirstOrDefault(u => u.productoid == detalleventa.producto);
                producto.stock = producto.stock - detalleventa.cantidad;
            }
            _context.SaveChanges();

            return true;

        }

    }
   
}



    

