using App.Data;
using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business
{
    public class ClienteNegocio
    {
        ClienteRepositorio _clienteRepositorio { get; set; }
        public ClienteNegocio(ClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
        public Boolean AgregarCliente(Cliente nuevoCliente)
        {
            return _clienteRepositorio.AgregarCliente(nuevoCliente);
        }
        public Boolean EditarCliente(Cliente editarCliente)
        {
            return _clienteRepositorio.EditarCliente(editarCliente);
        }
        public Response<Cliente> MostrarCliente(Search search)
        {
            return _clienteRepositorio.MostrarCliente(search);
        }
        public Boolean EliminarCliente(Search clienteid)
        {
            return _clienteRepositorio.EliminarCliente(clienteid);
        }
        public Cliente TraerCliente(Search search)
        {
            return _clienteRepositorio.TraerCliente(search);
        }
        public Response<Solicitud> solicitudesPendientes(Search search)
        {
            return _clienteRepositorio.solicitudesPendientes(search);
        }
    }
}
