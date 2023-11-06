using App.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class CobroRepositorio
    {
        private readonly Context _context;

        public CobroRepositorio(Context context)
        {
            _context = context;
        }
        public Response<Cobro> MostrarCobros(Search search)
        {
            var skipRows = ((search.PageIndex - 1) * search.PageSize);

            // Obtén todos los productos sin aplicar filtros
            IQueryable<Cobro> query = _context.Cobro.Include(p => p._factura).Include(p => p._cliente);

            if (!string.IsNullOrEmpty(search.TextToSearch) && search.num != 0) // Cambia 0 al valor predeterminado que desees para num
            {
                query = query.Where(p => p._factura.nrofactura == search.num && p._cliente.nombre.Contains(search.TextToSearch));
            }
            else if (!string.IsNullOrEmpty(search.TextToSearch))
            {
                query = query.Where(p => p._cliente.nombre.Contains(search.TextToSearch));
            }
            else if (search.num != 0) // Cambia 0 al valor predeterminado que desees para num
            {
                query = query.Where(p => p._factura.nrofactura == search.num);
            }


            var count = query.Count();
            var response = new Response<Cobro>()
            {
                Items = query.Skip(skipRows)
                             .Take(search.PageSize)
                             .ToList(),
                Total = count
            };

            return response;
        }
        public Boolean AgregarPago(Cobro cobro)
        {
            _context.Cobro.Add(cobro);
            _context.SaveChanges();
            return true;
        }
    }
}
