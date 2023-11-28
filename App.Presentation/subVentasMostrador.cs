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
    public partial class subVentasMostrador : Form

    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        public List<Producto> productosListados;
        public List<DetalleVenta> listardetalles;
        public Pedido pedido;
        public Cliente cliente;
        public Usuario usuario;
        decimal montoTotal;
        Vendedor vendedor;
        DialogResult result2;
        public subVentasMostrador(List<Producto> _productosListados, Usuario usuarioLogeado)
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            productosListados = _productosListados;
            cliente = new Cliente();
            pedido = new Pedido();
            usuario = new Usuario();
            vendedor = new Vendedor();
            listardetalles = new List<DetalleVenta>();
            result2 = new DialogResult();   
            usuario = usuarioLogeado;
        }

        private void subVentasMostrador_Load(object sender, EventArgs e)
        {


            foreach (var productoSeleccionado in productosListados)
            {
                DetalleVenta detalleVenta = new DetalleVenta
                {
                    // Asignar valores basados en el producto seleccionad             
                    producto = productoSeleccionado.productoid,
                    cantidad = productoSeleccionado.cantidadselec,
                    precio_total = productoSeleccionado.precioventa * productoSeleccionado.cantidadselec,
                    fecha = DateTime.Now,
                    _producto = productoSeleccionado
                };
                montoTotal = detalleVenta.precio_total + montoTotal;
                // Agregar el detalle de venta a la lista
                listardetalles.Add(detalleVenta);
            }
            lblTotalVenta.Text = montoTotal.ToString();

            string json = JsonConvert.SerializeObject(usuario);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Usuario/TraerVendedor", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            vendedor = JsonConvert.DeserializeObject<Vendedor>(jsonToDeserialize);

        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != null)
            {

                Search search = new Search()
                {
                    PageIndex = 0,
                    PageSize = 0,
                    TextToSearch = txtCliente.Text,
                };
                string json = JsonConvert.SerializeObject(search);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Cliente/TraerCliente", content).Result;
                var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
                cliente = JsonConvert.DeserializeObject<Cliente>(jsonToDeserialize);
                if (response.IsSuccessStatusCode && cliente != null)
                {
                    result2 = MessageBox.Show($"Cliente:{cliente.nombre} encontrado, desea confirmar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    lbCliente.Text = cliente.nombre;
                }
                else
                {
                    DialogResult result3 = MessageBox.Show("¿Cliente no encotrado desea agregarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result3 == DialogResult.Yes)
                    {
                        Form agregarCliente = new FormClientes();
                        agregarCliente.ShowDialog();
                    }
                  
                }
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)

        {
            Cobro cobro2 = new Cobro();
            Random random = new Random();
            int numero = random.Next(1, 1000);
          
            Factura factura = new Factura()
            {
                nrofactura = numero,
                montototal = montoTotal,
                fecha = DateTime.Now,
                cobrado = false,
            };
            Cobro cobro = new Cobro()
            {
                nrofactura = numero,
                fecha = DateTime.Now,
                tipo_comprobante = "FAC",
                debito = montoTotal,
                saldo = montoTotal,
                cliente = cliente.clienteid,
                nro_comprobante = numero

            };
            if (txtMonto.Text != null && cbMetodo != null)
            {

                cobro2.nrofactura = numero;
                cobro2.fecha = DateTime.Now;
                cobro2.tipo_comprobante = "CP";
                cobro2.debito = Convert.ToInt32(txtMonto.Text);
                cobro2.saldo = montoTotal - Convert.ToInt32(txtMonto.Text);
                cobro2.metodopago = cbMetodo.Text;
                cobro2.nro_comprobante = random.Next(1000, 2000);
                cobro2.cliente = cliente.clienteid;        
                if (cobro2.saldo == 0)
                {
                    factura.cobrado = true;
                }
            }
            pedido._venta = listardetalles;
            pedido.cliente = cliente.clienteid;
            pedido.vendedor = 1;
            pedido._factura = factura;
            pedido.fecha = DateTime.Now;
            pedido.factura = factura.nrofactura;
            if(cbEnvio.Text == "Si"){
                pedido.estado = "Confirmado";
            }
            else
            {
                pedido.estado = "Vendido";
            }
            string json = JsonConvert.SerializeObject(pedido);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"{_client.BaseAddress}/Pedido/AgregarPedido", content).Result;
            var jsonToDeserialize = response.Content.ReadAsStringAsync().Result;
            var  result = JsonConvert.DeserializeObject<Boolean>(jsonToDeserialize);
            if (result == true) {
                MessageBox.Show("OK", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {

                MessageBox.Show("No se pudo realizar la venta", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
          
            AgregarCobro(cobro);
            if(cobro2 != null)
            {
                AgregarCobro(cobro2);
            }
        }
        public Boolean AgregarCobro(Cobro cobro)
        {
            string json1 = JsonConvert.SerializeObject(cobro);
            StringContent content1 = new StringContent(json1, Encoding.UTF8, "application/json");
            HttpResponseMessage response1 = _client.PostAsync($"{_client.BaseAddress}/Cobro/AgregarPago", content1).Result;
            var jsonToDeserialize1 = response1.Content.ReadAsStringAsync().Result;
            var result1 = JsonConvert.DeserializeObject<Boolean>(jsonToDeserialize1);
            return result1;
        }
    }
}
