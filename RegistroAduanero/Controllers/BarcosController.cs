using Microsoft.AspNetCore.Mvc;
using RegistroAduanero.Entidades;
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
        public IActionResult RegistrarBarco(Barco nuevoBarco)
        {
            if (!ModelState.IsValid)
            {
                return View("Registrar");
            }

            this._servicioBarcos.RegistrarBarco(nuevoBarco);
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
