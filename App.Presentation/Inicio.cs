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
        private Usuario _usuarioLogeado;

        public Inicio(Usuario usuarioLogeado)
        {   
            _usuarioLogeado = new Usuario();
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _currentPage = 1;
            _currentItemsPerPage = 10;
            _textToSearch = "venta";
            _usuarioLogeado = usuarioLogeado;


        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void menuVentas_Click(object sender, EventArgs e)
        {


        }



        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuPedidos_Click(object sender, EventArgs e)
        {
            label2.Text = _usuarioLogeado.usuario;
        }


    }
}