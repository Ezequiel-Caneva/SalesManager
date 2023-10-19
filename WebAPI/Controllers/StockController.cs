﻿using App.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App.Entities;

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
        [HttpPost("AgregarProducto")]
        public void AgregarProducto(Producto nuevoProducto)
        {
            _stocknegocio.AgregarProducto(nuevoProducto);
        }
    }
}
