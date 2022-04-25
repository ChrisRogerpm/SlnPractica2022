using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinal_I_Unidad.Models;

namespace TrabajoFinal_I_Unidad.Controllers
{
    public class Ejercicio03Controller : Controller
    {
        // GET: Ejercicio03
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalcularOperacion(Ejercicio03 obj)
        {
            ClassRespuesta data = Ejercicio03.CalcularOperacion(obj);
            return Json(new { data });
        }
    }
}