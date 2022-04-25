using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinal_I_Unidad.Models;

namespace TrabajoFinal_I_Unidad.Controllers
{
    public class Ejercicio07Controller : Controller
    {
        // GET: Ejercicio07
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ObtenerListado()
        {
            string Valor = Ejercicio07.ObtenerData();
            //JObject jsonArray = JObject.Parse(Valor);
            return Json(new { data = Valor });
        }
    }
}