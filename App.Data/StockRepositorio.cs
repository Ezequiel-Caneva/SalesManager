using App.Entities;
using Microsoft.EntityFrameworkCore;
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
        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = _context.Producto.ToList();

            return productos;
        }
        public void AgregarProducto(Producto  nuevoProducto)
        {
            _context.Producto.Add(nuevoProducto); // Agrega el nuevo producto al contexto
            _context.SaveChanges(); // Guarda los cambios en la base de datos
        }
        public void EditarProducto(Producto editadoProducto)
        {
            var productoExistente = _context.Producto.Find(editadoProducto.productoid);

            if (productoExistente != null)
            {
                // Actualiza los campos con los nuevos valores
                productoExistente.nombre = editadoProducto.nombre;
                productoExistente.codigobarra = editadoProducto.codigobarra;
                productoExistente.precioventa = editadoProducto.precioventa;
                productoExistente.stock = editadoProducto.stock;
                productoExistente.rubro = editadoProducto.rubro;

                // Guarda los cambios en la base de datos
                _context.SaveChanges();
            }
        }
        public Boolean EliminarProducto(Search productoid)
        {
           
                var producto = _context.Producto.SingleOrDefault(p => p.productoid == Convert.ToInt32(productoid.TextToSearch)); // recuperar un único elemento de una secuencia que cumple con una condición específica. 

                if (producto != null)
                {
                    // Elimina el producto del contexto y de la base de datos
                    _context.Producto.Remove(producto);
                    _context.SaveChanges(); // Confirma la eliminación en la base de datos

                    return true; // Éxito en la eliminación
                }

                return false; // Producto no encontrado
         

        }
        public void AgregarRubro(Rubro nuevoRubro)
        {
            _context.Rubro.Add(nuevoRubro); // Agrega el nuevo producto al contexto
            _context.SaveChanges();
        }

        public Boolean EliminarRubro(Search search)
        {
            var Rubro = _context.Rubro.SingleOrDefault(p => p.rubroid == Convert.ToInt32(search.TextToSearch)); // recuperar un único elemento de una secuencia que cumple con una condición específica. 

            if (Rubro != null)
            {
                // Elimina el producto del contexto y de la base de datos
                _context.Rubro.Remove(Rubro);
                _context.SaveChanges(); // Confirma la eliminación en la base de datos

                return true; // Éxito en la eliminación
            }

            return false; // Producto no encontrado

        }
        //Mostrar todos los productos
        public Response<Producto> MostrarProducto(Search search)
        {
            var skipRows = ((search.PageIndex - 1) * search.PageSize);

            var query = _context.Producto
                        .Include(p => p._Rubro)
                        .Where(p => p.nombre.Contains(search.TextToSearch) || p._Rubro.categoria.Contains(search.TextToSearch));

            var count = query.Count();
            var response = new Response<Producto>()
            {
                Items = query.Skip(skipRows)
                             .Take(search.PageSize)
                             .ToList(),
                Total = count
            };

            return response;
        }
        public void EditarRubro(Rubro editadoRubro)
        {
            var rubroExistente = _context.Rubro.Find(editadoRubro.rubroid);
            if(rubroExistente != null)
            {
                rubroExistente.categoria = editadoRubro.categoria;
                _context.SaveChanges();
            }
        }
        public Response<Rubro> MostrarRubro(Search search)
        {
            var skipRows = ((search.PageIndex - 1) * search.PageSize);

            var ObtenerRubro1 = ObtenerRubro();
            var query = from m in ObtenerRubro1
                        where m.categoria.Contains(search.TextToSearch)
                        select m;


            var count = query.Count();
            var response = new Response<Rubro>()
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
