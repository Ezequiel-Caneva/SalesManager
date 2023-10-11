using Microsoft.AspNetCore.Mvc;
using App.Business;
using App.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/Permiso")]
    [ApiController]
    public class PermisoController : ControllerBase
    {
         
        private PermisoNegocio _permisoNegocio;
        public PermisoController(PermisoNegocio permisoNegocio)
        {
            _permisoNegocio = permisoNegocio;
        }
        [HttpPost("Obtener")]
        public Response<Permiso> ObtenerPermisos(string nombre)
        {
            return _permisoNegocio.ObtenerPermisos(nombre);
        }
    }
}
