using Microsoft.AspNetCore.Mvc;
using Practica1PWA.Models;

namespace Practica1PWA.Controllers
{
    public class ConversionesController : Controller
    {
        public IActionResult Index()
        {
            var model = new Conversiones();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Conversiones model)
        {
            if (ModelState.IsValid)
            {
                switch (model.TipoConversionId)
                {
                    case 1: // Celsius a Fahrenheit
                        model.ResultadoConversion = (model.ValorConversion * 9 / 5) + 32;
                        break;
                    case 2: // Metros a Pies
                        model.ResultadoConversion = model.ValorConversion * 3.28084;
                        break;
                    case 3: // Kilogramos a Libras
                        model.ResultadoConversion = model.ValorConversion * 2.20462;
                        break;
                    default:
                        ModelState.AddModelError("TipoConversionId", "Seleccione una conversión válida.");
                        break;
                }
            }

            return View(model);
        }
    }
}
