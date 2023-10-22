using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Data;
using App.Entities;

namespace App.Business
{
    public class PermisoNegocio
    {
        public PermisoRepositorio _permisoRepositorio;

        public PermisoNegocio(PermisoRepositorio permisoRepositorio) 
        {
            _permisoRepositorio = permisoRepositorio;
        }
        public Response<Permiso> ObtenerPermisos(Search search)
        {
            return _permisoRepositorio.ObtenerPermisos(search);
        }
       
    }
}
