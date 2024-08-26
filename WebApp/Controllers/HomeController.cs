using App.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("catalogo")]
        public IActionResult Catalogo()
        {
            try
            {
                var apiEndpoint = $"{_client.BaseAddress}/Stock/ObtenerProductosWeb";
                HttpResponseMessage response = _client.GetAsync(apiEndpoint).Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseData = response.Content.ReadAsStringAsync().Result;
                    var productos = JsonConvert.DeserializeObject<List<Producto>>(responseData);
                    return View(productos);
                }
                else
                {
                    return View("Error");
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Ocurrió un error al obtener los productos. Por favor, inténtelo de nuevo más tarde.";
                return View("Error");
            }
        }
        [Route("acercade")]
        public IActionResult Acercade()
        {
            return View();
        }
        [Route("contacto")]
        public IActionResult Contacto()
        {
            return View();
        }
        [Route("oferta")]
        public IActionResult Oferta()
        {
            try
            {
                var apiEndpoint = $"{_client.BaseAddress}/Stock/ObtenerPromocionWeb";
                HttpResponseMessage response = _client.GetAsync(apiEndpoint).Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseData = response.Content.ReadAsStringAsync().Result;
                    var promocion = JsonConvert.DeserializeObject<List<Promocion>>(responseData);
                    return View(promocion);
                }
                else
                {
                    return View("Error");
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Ocurrió un error al obtener las promociones. Por favor, inténtelo de nuevo más tarde.";
                return View("Error");
            }
        }
        public IActionResult Submit(string name, string email, string phone, string message)
        {

            var requestData = new Solicitud
            {
                nombre = name,
                email = email,
                telefono = phone,
                mensaje = message,
                estado = "salida"
            };
            string data = JsonConvert.SerializeObject(requestData);
            StringContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync(_client.BaseAddress + "/Cliente/Solicitud", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return View("Confirmation");
            }
            else
            {
                return View("Error");
            }
        }
        [Route("SeguirEnvio")]
        public IActionResult SeguirEnvio()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ConsultarEnvio(string dni, int clienteid)
        {
            var search = new
            {
                TextToSearch = dni,
                num = clienteid,
                TextToSearch2 = "",
                PageIndex = 1,
                PageSize = 20
            };

            var response = await _client.PostAsJsonAsync(_client.BaseAddress + "/Pedido/SeguirEnvioCliente", search);

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var pedidos = JsonConvert.DeserializeObject<Response<Pedido>>(jsonResponse);

                // Verifica que la respuesta no esté vacía
                if (pedidos != null && pedidos.Items.Count > 0)
                {
                    return View("Pedidos", pedidos);
                }
                else
                {
                    ViewBag.Message = "No se encontraron pedidos para los datos proporcionados.";
                    return View("Pedidos", pedidos); // Muestra la vista con mensaje
                }
            }

            ModelState.AddModelError("", "Error al buscar los pedidos. Por favor, intenta nuevamente.");
            return View("Pedidos"); // O una vista específica para errores
        }

        [Route("detalle-envio/{pedidoId}")]
        public async Task<IActionResult> DetalleEnvio(int pedidoId)
        {
            var apiEndpoint = $"{_client.BaseAddress}/Pedido/DetallesEnvio/{pedidoId}";
            HttpResponseMessage response = await _client.GetAsync(apiEndpoint);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                var envio = JsonConvert.DeserializeObject<Envio>(responseData);
                return View("envio", envio); // Devuelve la vista 'envio.cshtml' con los detalles del envío
            }

            return NotFound(); // Devuelve una página de error 404 si no se encuentra el detalle
        }


    }
}