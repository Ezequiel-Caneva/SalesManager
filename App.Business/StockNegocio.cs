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
        public Response<Producto> MostrarProducto(Search search)
        {
            return _stockRepositorio.MostrarProducto(search);
        }

    }
}
