using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Entities;
using Newtonsoft.Json;

namespace App.Presentation
{
    public partial class subMostrarEnvio : Form
    {

        private readonly Uri _baseAddress = new Uri("http://mototopAPI.somee.com/api");
        private readonly HttpClient _client;
        public int _pedidoid;
        public subMostrarEnvio(int pedidoid)
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _pedidoid = pedidoid;
        }

        private void subMostrarEnvio_Load(object sender, EventArgs e)
        {
            Search search = new Search()
            {
                PageIndex = 1,
                PageSize = 10,
                TextToSearch = _pedidoid.ToString(),
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Pedido/DetalleCliente", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Cliente>(jsonToDeserialize);
            var cliente = result;

            string json2 = JsonConvert.SerializeObject(search);
            StringContent content2 = new StringContent(json2, Encoding.UTF8, "application/json");
            HttpResponseMessage response2 = _client.PostAsync($"{_client.BaseAddress}/Pedido/DetalleEnvio", content2).Result;
            var jsonToDeserialize2 = response2.Content.ReadAsStringAsync().Result;
            var result2 = JsonConvert.DeserializeObject<Envio>(jsonToDeserialize2);
            var envio = result2;
            label11.Text = $"Envioid: {envio.envioid}";
            label2.Text = $"Condigo de Seguimiento: {envio.codigoseguimiento}";
            label3.Text = $"Fecha de envio: {envio.fecha_envio.ToString()}";
            label4.Text = $"Fecha de recepcion: {envio.fecha_recepcion.ToString()}";
            label5.Text = $"Empresa de transporte: {envio.empresa_transporte}";
            label6.Text = $"Cliente: {cliente.nombre}";
            label7.Text = $"Direccion: {cliente.direccion}";
            label8.Text = $"Telefono: {cliente.telefono}";
            label9.Text = $"Ciudad: {cliente.ciudad}";
            label10.Text = $"Codigo posta: {cliente.codigopostal}";
        }

    }
}
