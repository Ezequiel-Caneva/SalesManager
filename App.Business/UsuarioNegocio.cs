using App.Data;
using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.Business
{
    public class UsuarioNegocio
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;


        public UsuarioNegocio(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public void CrearUsuario(Usuario usuario)
        {
            _usuarioRepositorio.CrearUsuario(usuario);
        }
        public Usuario LogeoUsuario(LoginRequest request)
        {
            return _usuarioRepositorio.LogeoUsuario(request);
        }
        public void RegistrarVendedor(Vendedor vendedor)
        {
            _usuarioRepositorio.RegistrarVendedor(vendedor);
        }
        public Response<Vendedor> MostrarVendedores(Search search)
        {
            return _usuarioRepositorio.MostrarVendedores(search);
        }
        public Response<Pedido> InformeVendedor(Search search)
        {
            return _usuarioRepositorio.InformeVendedor(search);
        }
        public Response<DetalleVenta> InformeProducto(Search search)
        {
            return _usuarioRepositorio.InformeProducto(search);
        }

    }   
}
