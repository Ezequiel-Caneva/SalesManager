using App.Entities;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using System.Reflection;
using FontAwesome.Sharp;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        private static int dni;

        private static IconMenuItem _menuActivo = null;
        private static Form _formActivo = null;
        private List<Permiso> permisosUsuario;


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
            permisosUsuario = new List<Permiso>();
            permisosUsuario = ObtenerPermisos(_usuarioLogeado.usuario);

            var nombresMenuPermitidos = permisosUsuario.Select(p => p.nombremenu.ToLower()).ToList();

            foreach (IconMenuItem iconmenu in menuStrip1.Items)
            {
                if (!string.IsNullOrEmpty(iconmenu.Name))
                {
                    bool encontrado = nombresMenuPermitidos.Contains(iconmenu.Name.ToLower());
                    iconmenu.Visible = encontrado;
                }
            }

            Text = $"Usuario : {_usuarioLogeado.usuario}";
        }

        private void menuVentasMostrador_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormVentasMostrador(_usuarioLogeado));
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
        private void menuCobros_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormUsuarios());
        }
        private void menuVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Ventas());
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

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }
        public List<Permiso> ObtenerPermisos(string nombre)
        {
            Search e = new Search()
            {
                TextToSearch = nombre,
            };
            string json = JsonConvert.SerializeObject(e);

            // Crear el contenido de la solicitud
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            // Realizar la solicitud POST
            HttpResponseMessage response = _client.PostAsync(_client.BaseAddress + "/permiso/obtener", content).Result;

            // Verificar si la respuesta es exitosa
            if (response.IsSuccessStatusCode)
            {
                // Leer y deserializar la respuesta
                var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
                var usuarioPermisos = JsonConvert.DeserializeObject<Response<Permiso>>(jsonToDeserialize);
                return usuarioPermisos.Items;
            }
            else
            {
                // Manejar el error de la respuesta (código de estado 400)
                // Puedes registrar el error o manejarlo de la manera que necesites.
                throw new Exception("Error en la solicitud: " + response.ReasonPhrase);
            }
        }

        
    }
}