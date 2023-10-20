using Microsoft.AspNetCore.Mvc;
using App.Business;
using App.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/permiso")]
    [ApiController]
    public class PermisoController : ControllerBase
    {
         
        private PermisoNegocio _permisoNegocio;
        public PermisoController(PermisoNegocio permisoNegocio)
        {
            _permisoNegocio = permisoNegocio;
        }
        [HttpPost("obtener")]
        public Response<Permiso> ObtenerPermisos(Search search)
        {
            return _permisoNegocio.ObtenerPermisos(search);
        }

    }
}
