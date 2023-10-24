using App.Business;
using Microsoft.AspNetCore.Mvc;
using App.Business;
using App.Entities;
namespace WebAPI.Controllers
{
    [Route("api/Cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public ClienteNegocio _clienteNegocio;
        public ClienteController(ClienteNegocio clienteNegocio)
        {
            _clienteNegocio = clienteNegocio;
        }
        [HttpPost("AgregarCliente")]
        public Boolean AgregarCliente(Cliente nuevoCliente)
        {
            return _clienteNegocio.AgregarCliente(nuevoCliente);
        }
        [HttpPost("EditarCliente")]
        public Boolean EditarCliente(Cliente editarCliente)
        {
            return _clienteNegocio.EditarCliente(editarCliente);
        }
     
        [HttpPost("MostrarCliente")]
        public Response<Cliente> MostrarCliente(Search search)
        {
            return _clienteNegocio.MostrarCliente(search);
        }
        [HttpPost("EliminarCliente")]
        public Boolean EliminarCliente(Search clienteid)
        {
            return _clienteNegocio.EliminarCliente(clienteid);
        }
    


    }
}
