using App.Data;
using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business
{
    public class StockNegocio
    {
        private readonly StockRepositorio _stockRepositorio;

        public StockNegocio(StockRepositorio stockRepositorio)
        {
            _stockRepositorio = stockRepositorio;
        }

        public List<Rubro> ObtenerRubro()
        {
            return _stockRepositorio.ObtenerRubro();
        }
        
        
        public void AgregarProducto(Producto nuevoProducto)
        {
            _stockRepositorio.AgregarProducto(nuevoProducto);

        }
        public void EditarProducto(Producto editadoProducto)
        {
            _stockRepositorio.EditarProducto(editadoProducto);
        }
        public Boolean EliminarProducto(Search productoid)
        {
            return _stockRepositorio.EliminarProducto(productoid);
        }
        public void AgregarRubro(Rubro nuevoRubro)
        {
            _stockRepositorio.AgregarRubro(nuevoRubro);
        }
        public void EditarRubro(Rubro nuevoRubro)
        {
            _stockRepositorio.EditarRubro(nuevoRubro);
        }
        public Boolean EliminarRubro(Search search)
        {
            return _stockRepositorio.EliminarRubro(search);
        }

        public Response<Producto> MostrarProducto(Search search)
        {
            return _stockRepositorio.MostrarProducto(search);
        }
        public Response<Rubro> MostrarRubro(Search search)
        {
            return _stockRepositorio.MostrarRubro(search);
        }
        // se utiliza en el formulario Compras
        public List<Producto> ObtenerProductos()
        {
            return _stockRepositorio.ObtenerProductos();
        }
    }
}
