using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinal_I_Unidad.Models;

namespace TrabajoFinal_I_Unidad.Controllers
{
    public class Ejercicio05Controller : Controller
    {
        // GET: Ejercicio05
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalcularTriangulo(Ejercicio05 obj)
        {
            string Triangulo = Ejercicio05.CalcularTriangulo(obj);
            return Json(new { data = Triangulo });
        }
    }
}