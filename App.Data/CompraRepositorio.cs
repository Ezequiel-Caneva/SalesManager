using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class CompraRepositorio
    {
        private readonly Context _context;

        public CompraRepositorio(Context context)
        {
            _context = context;
        }
        public void CargarCompra(DetalleCompra compra)
        {
            _context.Compra.Add(compra); // Agrega el nuevo producto al contexto
            _context.SaveChanges();
            var modificarcantidad = _context.Producto.Find(compra.productoid);
            if (modificarcantidad != null)
            {
                modificarcantidad.stock = modificarcantidad.stock + compra.cantidad;
                _context.SaveChanges();
            }
        }
        public Response<DetalleCompra> MostrarCompras(Search search)
        {
            var skipRows = ((search.PageIndex - 1) * search.PageSize);

            // Obtén todos los productos sin aplicar filtros
            var query = _context.Compra.AsQueryable();


            var count = query.Count();
            var response = new Response<DetalleCompra>()
            {
                Items = query.Skip(skipRows)
                             .Take(search.PageSize)
                             .ToList(),
                Total = count
            };

            return response;
        }
    }
}
