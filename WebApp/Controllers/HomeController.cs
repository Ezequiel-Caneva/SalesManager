using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [Route("catalogo")]
        public IActionResult Catalogo()
        {
            return View();
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
            return View();
        }
    }
}