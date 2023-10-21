using App.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        public Boolean EliminarCompra(DetalleCompra eliminar)
        {

            var compra = _context.Compra.SingleOrDefault(p => p.productoid == eliminar.productoid && p.proveedorid == eliminar.proveedorid); // recuperar un único elemento de una secuencia que cumple con una condición específica. 

            if (compra != null)
            {
                // Elimina el producto del contexto y de la base de datos
                _context.Compra.Remove(compra);
                _context.SaveChanges(); // Confirma la eliminación en la base de datos

                return true; // Éxito en la eliminación
            }

            return false; // Producto no encontrado


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
        public DataTable GetCombinedData()
        {
            using (SqlConnection connection = new SqlConnection("cadena de conexión"))
            {
                connection.Open();
                string query = "SELECT Tabla1.Columna1, Tabla1.Columna2, Tabla2.Columna3 " +
                               "FROM Tabla1 " +
                               "INNER JOIN Tabla2 ON Tabla1.ClaveForanea = Tabla2.ClavePrimaria";
              
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }
}
