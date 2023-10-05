using App.Entities;
using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class Repository
    {
        private Context _context;

        public Repository(Context context)
        {
            _context = context;
        }

        public Entities.Response<Venta> GetVentasPaginas(Search search)
        {

            var skipRows = ((search.PageIndex - 1) * search.PageSize);

            var query = _context.Ventas.ToList();

            var count = query.Count();
           

            var response = new Entities.Response<Venta>()
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
