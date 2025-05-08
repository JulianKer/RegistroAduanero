using Microsoft.AspNetCore.Mvc;
using RegistroAduanero.Entidades;
using RegistroAduanero.Models;
using RegistroAduanero.Servicios;

namespace RegistroAduanero.Controllers
{
    public class BarcosController : Controller
    {
        private IServicioBarcos _servicioBarcos;

        public BarcosController(IServicioBarcos servicioBarcos)
        {
            this._servicioBarcos = servicioBarcos;
        }

        // registro ------------------------------------------
        public IActionResult Registrar() // este me va a mostrar el form
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarBarco(BarcoViewModel nuevoBarcoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Registrar");
            }

            Barco barcoMapeado = nuevoBarcoViewModel.MapearseAEntidadBarco();
            this._servicioBarcos.RegistrarBarco(barcoMapeado);

            return RedirectToAction("Listado");
        }
        //---------------------------------------------------





        // listado ------------------------------------------
        public IActionResult Listado()
        {
            return View(_servicioBarcos.ObtenerBarcos());
        }
        // --------------------------------------------------
    }
}
