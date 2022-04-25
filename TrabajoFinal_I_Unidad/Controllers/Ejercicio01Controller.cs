using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinal_I_Unidad.Models;

namespace TrabajoFinal_I_Unidad.Controllers
{
    public class Ejercicio01Controller : Controller
    {
        // GET: Ejercicio01
        //Ejercicio01 objnew = new Ejercicio01();        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalcularOperacion(Ejercicio01 obj)
        {
            _ = new Ejercicio01();
            Ejercicio01 newObj = Ejercicio01.CalcularRetiro(obj);
            return Json(new { data = newObj });
        }
    }
}