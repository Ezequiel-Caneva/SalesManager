using App.Data;
using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business
{
    public class CompraNegocio
    {
        public CompraRepositorio _comprasRepositorio;
        public CompraNegocio(CompraRepositorio comprasRepositorio)
        {
            _comprasRepositorio = comprasRepositorio;
        }
        public void CargarCompra(DetalleCompra compra)
        {
            _comprasRepositorio.CargarCompra(compra);
        }
        public Response<DetalleCompra> MostrarCompras(Search search)
        {
            return _comprasRepositorio.MostrarCompras(search);
        }
        public Boolean EliminarCompra(DetalleCompra eliminar)
        {
            return _comprasRepositorio.EliminarCompra(eliminar);
        }
    }
}
