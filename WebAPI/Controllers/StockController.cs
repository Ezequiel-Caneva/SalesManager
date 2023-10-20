using App.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App.Entities;
using App.Data;

namespace WebAPI.Controllers
{
    [Route("api/Stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private StockNegocio _stocknegocio;

        public StockController(StockNegocio stocknegocio)
        {
            _stocknegocio = stocknegocio;
        }
        [HttpGet("ObtenerRubro")]
        public List<Rubro> ObtenerRubro()
        {
            return _stocknegocio.ObtenerRubro();
        }

        //Productos
        [HttpPost("AgregarProducto")]
        public void AgregarProducto(Producto nuevoProducto)
        {
            _stocknegocio.AgregarProducto(nuevoProducto);
        }
        [HttpPost("EditarProducto")]
        public void EditarProducto(Producto editadoProducto)
        {
            _stocknegocio.EditarProducto(editadoProducto);
        }
        [HttpPost("EliminarProducto")]
        public Boolean EliminarProducto(Search productoid)
        {
            return _stocknegocio.EliminarProducto(productoid);
        }

        //Rubros
        [HttpPost("AgregarRubro")]
        public void AgregarRubro(Rubro nuevoRubro)
        {
            _stocknegocio.AgregarRubro(nuevoRubro);
        }
        [HttpPost("EditarRubro")]
        public void EditarRubro(Rubro nuevoRubro)
        {
            _stocknegocio.EditarRubro(nuevoRubro);
        }



        //Mostar rubros y productos en dgv
        [HttpPost("MostrarProducto")]
        public Response<Producto> MostrarProducto(Search search)
        {
            return _stocknegocio.MostrarProducto(search);
        }
        [HttpPost("MostrarRubro")]
        public Response<Rubro> MostrarRubro(Search search)
        {
            return _stocknegocio.MostrarRubro(search);
        }



    }
}
