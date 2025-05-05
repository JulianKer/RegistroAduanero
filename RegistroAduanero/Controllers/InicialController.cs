using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RegistroAduanero.Models;

namespace RegistroAduanero.Controllers
{
    public class InicialController : Controller
    {
        private readonly ILogger<InicialController> _logger;

        public InicialController(ILogger<InicialController> logger)
        {
            _logger = logger;
        }

        public IActionResult Hola()
        {
            ViewBag.msj = "Bienvenido al sitio de Registro Aduanero de Barcos";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
