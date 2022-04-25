using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace TrabajoFinal_I_Unidad.Models
{
    public class Ejercicio07
    {
        public static string ObtenerData()
        {
            string strText = "";            
            using (StreamReader r = new StreamReader(System.Web.HttpContext.Current.Server.MapPath("~/assets/planesEstudio.json")))
            {
                strText = r.ReadToEnd();
            }
            return strText;
        }
    }
}