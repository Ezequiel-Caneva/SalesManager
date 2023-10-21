using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App.Entities;
using App.Data;
using App.Business;

namespace WebAPI.Controllers
{
    [Route("api/Proveedor")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private ProveedorNegocio _proveedorNegocio;

        public ProveedorController(ProveedorNegocio proveedorNegocio)
        {
            _proveedorNegocio = proveedorNegocio;
        }

        [HttpPost("AgregarProveedor")] 
        public void AgregarProveedor(Proveedor proveedor){
            _proveedorNegocio.AgregarProveedor(proveedor);
         }
        [HttpPost("EditarProveedor")]
        public void EditarProveedor(Proveedor editadoProveedor)
        {
            _proveedorNegocio.EditarProveedor(editadoProveedor);
        }
        [HttpPost("EliminarProveedor")]
        public Boolean EliminarProveedor(Search productoid)
        {
            return _proveedorNegocio.EliminarProveedor(productoid);
        }

        [HttpPost("MostrarProveedor")]
        public Response<Proveedor> MostrarProveedores(Search search)
        {
            return _proveedorNegocio.MostrarProveedores(search);
        }
        [HttpGet("ObtenerProveedores")]
        public List<Proveedor> ObtenerProveedores()
        {
            return _proveedorNegocio.ObtenerProveedores();
        }

    }
}
