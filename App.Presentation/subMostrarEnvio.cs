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

        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
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
            label1.Text = $"Envioid: {envio.envioid} \n" +
                          $"Condigo de Seguimiento: {envio.codigoseguimiento}\n" +
                          $"Fecha de envio: {envio.fecha_envio.ToString()}\n" +
                          $"Fecha de recepcion: {envio.fecha_recepcion.ToString()}\n" +
                          $"Empresa de transporte: {envio.empresa_transporte}\n" +
                          $"Cliente: {cliente.nombre}\n" +
                          $"Direccion: {cliente.direccion}\n" +
                          $"Telefono: {cliente.telefono}\n" +
                          $"Ciudad: {cliente.ciudad}\n" +
                          $"Codigo posta: {cliente.codigopostal}";
        }

    }
}
