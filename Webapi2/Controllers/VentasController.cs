using App.Business;
using App.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Webapi2.Controllers
{
    [Route("api/Ventas")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        public Business _business;
        public VentasController()
        {
            _business = new Business();
        }
   

        
        [HttpPost("Mostrar")]
        public Response<Venta> SearchInbox([FromBody] Search search)
        {
            return _business.GetVentas(search);

        }

    }
}
