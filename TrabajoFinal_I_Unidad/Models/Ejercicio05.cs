using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabajoFinal_I_Unidad.Models
{
    public class Ejercicio05
    {
        public int Cantidad
        {
            get; set;
        }
        public static string CalcularTriangulo(Ejercicio05 obj)
        {
            string triangulo = "";
            for (int i = 0; i < obj.Cantidad; i++)
            {
                for (int k = 0; k < (obj.Cantidad - 1) - i; k++)
                {
                    triangulo += "&ensp;";
                }
                for (int k = 0; k < i * 2 + 1; k++)
                {
                    triangulo += i;
                }
                triangulo += "<br>";

            }
            return triangulo;
        }
    }
}