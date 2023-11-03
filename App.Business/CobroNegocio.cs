using App.Data;
using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business
{
    public class CobroNegocio
    {
        public CobroRepositorio _cobroRepositorio;
        public CobroNegocio(CobroRepositorio cobroRepositorio)
        {
            _cobroRepositorio = cobroRepositorio;
        }
        public Response<Cobro> MostrarCobros(Search search)
        {
            return _cobroRepositorio.MostrarCobros(search);
        }
    }
}
