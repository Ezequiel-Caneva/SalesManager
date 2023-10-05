using App.Data;
using App.Entities;
using Azure;

namespace App.Business
{
    public class Business
    {
        private Repository _repository;

        public Business(Repository repository)
        {
            _repository = repository;
        }

      
        public Entities.Response<Venta> GetVentas(Search search)
        {
            return _repository.GetVentasPaginas(search);
        }

    }
}