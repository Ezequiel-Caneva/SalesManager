using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class StockRepositorio
    {

        private readonly Context _context;

        public StockRepositorio(Context context)
        {
            _context = context;
        }
        public List<Rubro> ObtenerRubro()
        {
            List<Rubro> rubros = _context.Rubro.ToList();

            return rubros;
        }
        public void AgregarProducto(Producto  nuevoProducto)
        {
            _context.Producto.Add(nuevoProducto); // Agrega el nuevo producto al contexto
            _context.SaveChanges(); // Guarda los cambios en la base de datos
        }
    }
}
