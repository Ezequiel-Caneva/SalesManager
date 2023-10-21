using App.Business;
using App.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/Compra")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        public CompraNegocio _comprasNegocio;
        public CompraController(CompraNegocio comprasNegocio)
        {
            _comprasNegocio = comprasNegocio;
        }
        [HttpPost("CargarCompra")]
        public void CargarCompra(DetalleCompra compra)
        {
            _comprasNegocio.CargarCompra(compra);
        }
        [HttpPost("MostrarCompras")]
        public Response<DetalleCompra> MostrarCompras(Search search)
        {
            return _comprasNegocio.MostrarCompras(search);
        }
        

    }
}
