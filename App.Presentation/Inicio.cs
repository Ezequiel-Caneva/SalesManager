using App.Entities;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using System.Reflection;
using FontAwesome.Sharp;

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

        private static IconMenuItem _menuActivo = null;
        private static Form _formActivo = null;


        public Inicio(Usuario usuarioLogeado)
        {
            _usuarioLogeado = new Usuario();
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _usuarioLogeado = usuarioLogeado;
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            Text = $"Usuario : {_usuarioLogeado.usuario}";
        }

        private void menuVentasMostrador_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormVentasMostrador());
        }
        private void menuPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormPedidos());
        }
        private void menuVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormVentas());
        }
        private void menuCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormCompras());
        }
        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormClientes());
        }
        private void menuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormProveedores());
        }
        private void menuStock_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormStock());
        }
        private void menuInformes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormInformes());
        }
        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormUsuarios());
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (_menuActivo != null)
            {
                _menuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.White;
            _menuActivo = menu;
            if (_formActivo != null)
            {
                _formActivo.Close();
            }
            _formActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}