using App.Data;
using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business
{
    public class ProveedorNegocio
    {
        public ProveedorRepositorio _proveedorRepositorio;
        public ProveedorNegocio(ProveedorRepositorio proveedorRepositorio)
        {
            _proveedorRepositorio = proveedorRepositorio;
        }
        public void AgregarProveedor(Proveedor proveedor)
        {
            _proveedorRepositorio.AgregarProveedor(proveedor);
        }
        public void EditarProveedor(Proveedor editadoProveedor)
        {
            _proveedorRepositorio.EditarProveedor(editadoProveedor);
        }
        public Boolean EliminarProveedor(Search proveedorid)
        {  
            return _proveedorRepositorio.EliminarProveedor(proveedorid);
        }

            public Response<Proveedor> MostrarProveedores(Search search)
        {
            return _proveedorRepositorio.MostrarProveedores(search);
        }
        public List<Proveedor> ObtenerProveedores()
        {
            return _proveedorRepositorio.ObtenerProveedores();
        }

    }

}
