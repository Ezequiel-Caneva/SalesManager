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

        public UsuarioNegocio() { }
        public UsuarioNegocio(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public void CrearUsuario(int dni, string username, string password, string email, int rol)
        {
            // Llama al repositorio para almacenar el usuario en la base de datos
            _usuarioRepositorio.CrearUsuario(dni,username,password,email, rol);
        }
        public bool Logeo(LoginRequest request)
        {
            return _usuarioRepositorio.Logeo(request);
        }



    }
}
