using App.Business;
using App.Data;
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
        [HttpPost("CrearUsuario")]
        public void CrearUsuario(Usuario usuario)
        {
            _usuarionegocio.CrearUsuario(usuario);
        }
        [HttpPost("RegistrarVendedor")]
        public void RegistrarVendedor(Vendedor vendedor)
        {
            _usuarionegocio.RegistrarVendedor(vendedor);
        }
        [HttpPost("MostrarVendedores")]
        public Response<Vendedor> MostrarVendedores(Search search)
        {
            return _usuarionegocio.MostrarVendedores(search);
        }
        [HttpPost("InformeVendedor")]
        public Response<Pedido> InformeVendedor(Search search)
        {
            return _usuarionegocio.InformeVendedor(search);
        }
        [HttpPost("InformeProducto")]
        public Response<DetalleVenta> InformeProducto(Search search)
        {
            return _usuarionegocio.InformeProducto(search);
        }

    }
}




