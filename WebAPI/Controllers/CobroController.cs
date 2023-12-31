﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App.Business;
using App.Entities;
using App.Data;

namespace WebAPI.Controllers
{
    [Route("api/Cobro")]
    [ApiController]
    public class CobroController : ControllerBase
    {
        public CobroNegocio _cobroNegocio;
        public CobroController(CobroNegocio cobroNegocio) {
            _cobroNegocio = cobroNegocio;
        }
        [HttpPost("MostrarCobros")]
        public Response<Cobro> MostrarCobros(Search search)
        {
            return _cobroNegocio.MostrarCobros(search);
        }
        [HttpPost("AgregarPago")]
        public Boolean AgregarPago(Cobro cobro)
        {
            return _cobroNegocio.AgregarPago(cobro);
        }
    }
}
