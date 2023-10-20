using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class ProveedorRepositorio
    {
        private readonly Context _context;

        public ProveedorRepositorio(Context context)
        {
            _context = context;
        }
        public void AgregarProveedor(Proveedor proveedor)
        {
            _context.Proveedor.Add(proveedor); // Agrega el nuevo producto al contexto
            _context.SaveChanges(); // Guarda los cambios en la base de datos
        }
        public void EditarProveedor(Proveedor editadoProveedor)
        {
            var proveedorExistente = _context.Proveedor.Find(editadoProveedor.proveedorid);
            if (proveedorExistente != null)
            {
                proveedorExistente.nombre = editadoProveedor.nombre;
                proveedorExistente.direccion = editadoProveedor.direccion;
                proveedorExistente.razonsocial = editadoProveedor.razonsocial;
                proveedorExistente.telefono = editadoProveedor.telefono;
                _context.SaveChanges();
            }
        }
        public Boolean EliminarProveedor(Search proveedorid)
        {

            var proveedor = _context.Proveedor.SingleOrDefault(p => p.proveedorid == Convert.ToInt32(proveedorid.TextToSearch)); // recuperar un único elemento de una secuencia que cumple con una condición específica. 

            if (proveedor != null)
            {
                // Elimina el producto del contexto y de la base de datos
                _context.Proveedor.Remove(proveedor);
                _context.SaveChanges(); // Confirma la eliminación en la base de datos

                return true; // Éxito en la eliminación
            }

            return false; // Producto no encontrado


        }
        public Response<Proveedor> MostrarProveedores(Search search)
        {
            var skipRows = ((search.PageIndex - 1) * search.PageSize);

            // Obtén todos los productos sin aplicar filtros
            var query = _context.Proveedor.AsQueryable();


            var count = query.Count();
            var response = new Response<Proveedor>()
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
