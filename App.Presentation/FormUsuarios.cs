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
    public partial class FormUsuarios : Form
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        private int _currentItemsPerPage;
        private int _currentPage;
        public FormUsuarios()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _currentPage = 1;
            _currentItemsPerPage = 25;

        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario()
            {
                dni = Convert.ToInt32(txtDni.Text),
                usuario = txtNombre.Text,
                contraseniahash = txtContrasenia.Text,
                email = txtEmail.Text,
                rol = 2,
            };

            string data = JsonConvert.SerializeObject(usuario);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Usuario/CrearUsuario", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Usuario Creado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se crear el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Vendedor vendedor = new Vendedor()
            {
                usuarioid = Convert.ToInt32(txtDni.Text),
                zona = txtZona.Text,
            };
            string data1 = JsonConvert.SerializeObject(vendedor);
            StringContent content1 = new StringContent(data1, Encoding.UTF8, "application/json");
            HttpResponseMessage response1 = _client.PostAsync($"{_client.BaseAddress}/Usuario/RegistrarVendedor", content1).Result;
            var jsonToDeserialize1 = response1.Content.ReadAsStringAsync().Result;

            if (response1.IsSuccessStatusCode)
            {
                MessageBox.Show("Vendedor Registrado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo registrar el Vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MostrarUsuarios();
        }
        public void MostrarUsuarios()
        {
            Search search = new Search()
            {
                PageIndex = _currentPage,
                PageSize = _currentItemsPerPage,
                TextToSearch = "",
            };
            string json = JsonConvert.SerializeObject(search);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Usuario/MostrarVendedores", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Response<Vendedor>>(jsonToDeserialize);

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Dni", typeof(int));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Zona", typeof(string));


            foreach (var item in result.Items)
            {
                DataRow row = dataTable.NewRow();

                row["Id"] = item.vendedorid;
                row["Nombre"] = item.usuario.usuario;
                row["Dni"] = item.usuarioid;
                row["Email"] = item.usuario.email;
                row["Zona"] = item.zona;
                dataTable.Rows.Add(row);

            }
            dgvVendedores.DataSource = dataTable;
            dgvVendedores.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
