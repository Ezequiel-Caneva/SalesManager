using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class PermisoRepositorio
    {
        private readonly Context _context;

        public PermisoRepositorio(Context context)
        {
            _context = context;
        }
        public Response<Permiso> ObtenerPermisos(string nombre)
        {
            
            var usuario = _context.Usuario.FirstOrDefault(u => u.usuario == nombre);

            var rol = _context.Rol.FirstOrDefault(r => r.rolid == usuario.rol);

            var permisos = _context.Permiso.Where(p => p.rol == rol.rolid).ToList();
            var count = permisos.Count();

            var response = new Response<Permiso>()
            {
                Items = permisos,
                Total = count
            };


            return response;
        }
    }
}
