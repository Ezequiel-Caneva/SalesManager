using App.Business;
using App.Data;
using App.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/Ventas")]
    [ApiController]
    
   
    public class VentasController : ControllerBase
    {
        private Business _business;
        public VentasController(Business business)
        {
          
            _business = business;
        }

        [HttpPost("Mostrar")]
        public Response<Venta> GetVentas(Search search)
        {
            return _business.GetVentas(search);
        }
    }
}
