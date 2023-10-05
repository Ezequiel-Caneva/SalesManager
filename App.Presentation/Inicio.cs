using App.Entities;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using System.Reflection;

namespace App.Presentation
{
    public partial class Inicio : Form
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        private int _currentItemsPerPage;
        private int _currentPage;
        private string _textToSearch;
        public Inicio()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _currentPage = 1;
            _currentItemsPerPage = 10;
            _textToSearch = "venta";
            contenedor.Visible = false;
         
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void menuVentas_Click(object sender, EventArgs e)
        {
            
            contenedor.Visible = true;
            var resultado = Mostrar(_currentPage, _currentItemsPerPage, _textToSearch);
            dgvVentas.DataSource = resultado.Items;

        }

      

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuPedidos_Click(object sender, EventArgs e)
        {
           
        }

       
        private Response<Venta> Mostrar(int _currentPage, int _currentItemsPerPage,string _textToSearch)
        {
            Search search = new Search()
            {
                PageIndex = _currentPage,
                PageSize = _currentItemsPerPage,
                TextToSearch = _textToSearch,
            };

            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = _client.PostAsync(_client.BaseAddress + "/Ventas/Mostrar", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var resultado = JsonConvert.DeserializeObject<Response<Venta>>(jsonToDeserialize);
            return resultado;
        }
        
    }
}