using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class ClienteRepositorio
    {
        private readonly Context _context;

        public ClienteRepositorio(Context context)
        {
            _context = context;
        }
        public Boolean AgregarCliente(Cliente nuevoCliente)
        {
            Boolean verificar = _context.Cliente.Any(c => c.dni == nuevoCliente.dni);

            if (verificar == true)
            {
                // El cliente ya existe, no lo agregues y devuelve falso para indicar que no se realizó la operación.
                return false;
            }
            else
            {
                // El cliente no existe, agrégalo a la base de datos y guarda los cambios.
                _context.Cliente.Add(nuevoCliente);
                _context.SaveChanges();
                return true;
            }

        }
        public Boolean EditarCliente(Cliente editarCliente)
        {
            bool verificar = _context.Cliente.Any(c => c.dni == editarCliente.dni);
            if (verificar == true)
            {
                var clienteExistente = _context.Cliente.Find(editarCliente.clienteid);

                if (clienteExistente != null )
                {

                    // Actualiza los campos con los nuevos valores
                    clienteExistente.nombre = editarCliente.nombre;
                    clienteExistente.dni = editarCliente.dni;   
                    clienteExistente.ciudad = editarCliente.ciudad;
                    clienteExistente.codigopostal = editarCliente.codigopostal;
                    clienteExistente.telefono = editarCliente.telefono;
                    if (clienteExistente.email != editarCliente.email)  
                    {
                        clienteExistente.email = editarCliente.email;
                    }
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
        public Boolean EliminarCliente(Search clienteid)
        {

            var cliente = _context.Cliente.SingleOrDefault(p => p.clienteid == Convert.ToInt32(clienteid.TextToSearch)); // recuperar un único elemento de una secuencia que cumple con una condición específica. 

            if (cliente != null)
            {
                // Elimina el producto del contexto y de la base de datos
                _context.Cliente.Remove(cliente);
                _context.SaveChanges(); // Confirma la eliminación en la base de datos

                return true; // Éxito en la eliminación
            }

            return false; // Producto no encontrado
        }
        public Response<Cliente> MostrarCliente(Search search)
        {
            var skipRows = ((search.PageIndex - 1) * search.PageSize);
            // Obtén todos los productos sin aplicar filtros
            var query = _context.Cliente.AsQueryable()
                 .Where(p => p.nombre.Contains(search.TextToSearch) || p.dni.Contains(search.TextToSearch) || p.ciudad.Contains(search.TextToSearch) || p.direccion.Contains(search.TextToSearch) || p.email.Contains(search.TextToSearch));
            var count = query.Count();
            var response = new Response<Cliente>()
            {
                Items = query.Skip(skipRows)
                             .Take(search.PageSize)
                             .ToList(),
                Total = count
            };

            return response;
        }
        public Cliente TraerCliente(Search search)
        {
            var cliente = _context.Cliente.SingleOrDefault(p => p.dni == search.TextToSearch);
            return cliente;
        }

    }
}
