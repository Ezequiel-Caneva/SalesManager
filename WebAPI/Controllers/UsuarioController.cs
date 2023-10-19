﻿using App.Business;
using App.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NuGet.Protocol.Plugins;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/Usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private UsuarioNegocio _usuarionegocio;
       
        public UsuarioController(UsuarioNegocio usuarionegocio)
        {
            _usuarionegocio = usuarionegocio;
        }
        [HttpPost("Login")]
        public Usuario LogeoUsuario(LoginRequest request)
        {
            return _usuarionegocio.LogeoUsuario(request);
        }
      
    }
}



