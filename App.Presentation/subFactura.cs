using App.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Presentation
{
    public partial class subFactura : Form
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        private int pedidoId;
        public subFactura(int pedidoid)
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            pedidoId = pedidoid;
        }

        private void subFactura_Load(object sender, EventArgs e)
        {
            var pedido = BuscarFactura(pedidoId);

            List<string> list = pedido._venta.Select(x => x.ToString()).ToList();
            string elementosformateados = string.Join("\n", list);

            lblFactura.Text = $"N° factura {pedido._factura.nrofactura}\n" +
                                $"fecha {pedido._factura.fecha}\n" +
                                $"{elementosformateados}" +
                                $"Monto total : {pedido._factura.montototal}";

        }
        private Pedido BuscarFactura(int pedidoId)
        {
            Search search = new Search()
            {
                PageIndex = 1,
                PageSize = 10,
                TextToSearch = pedidoId.ToString(),
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Pedido/ObtenerPedido", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Pedido>(jsonToDeserialize);
            return result;
        }

        private void lblFactura_Click(object sender, EventArgs e)
        {

        }
    }
}
