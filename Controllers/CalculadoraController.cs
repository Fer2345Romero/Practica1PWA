using Microsoft.AspNetCore.Mvc;
using Practica1PWA.Models;

namespace Practica1PWA.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            var model = new Operaciones();
            return View(model);
        }
    
        [HttpPost]
        public IActionResult Index(Operaciones model)
        {
            if (ModelState.IsValid)
            {
                if (model.TipoOperacionId == 1)
                {
                    model.Resultado = model.PrimerDato + model.SegundoDato;
                }
                else if (model.TipoOperacionId == 2)
                {
                    model.Resultado = model.PrimerDato - model.SegundoDato;
                }
                else if (model.TipoOperacionId == 3)
                {
                    model.Resultado = model.PrimerDato * model.SegundoDato;
                }
                else if (model.TipoOperacionId == 4)
                {
                    if (model.SegundoDato != 0)
                    {
                        model.Resultado = model.PrimerDato / model.SegundoDato;
                    }
                }
            }



           return View(model);
        }
    }
}

