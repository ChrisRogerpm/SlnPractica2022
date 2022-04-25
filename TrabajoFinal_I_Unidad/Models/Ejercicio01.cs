using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabajoFinal_I_Unidad.Models
{
    public class Ejercicio01
    {
        public int ValorEntrante { get; set; }
        public int Accion { get; set; }
        public int ValorCien { get; set; }
        public int ValorCincuenta { get; set; }
        public int ValorVeinte { get; set; }
        public int ValorDiez { get; set; }

        public static Ejercicio01 CalcularRetiro(Ejercicio01 obj)
        {
            Ejercicio01 newObj = new Ejercicio01();
            int residuo = obj.ValorEntrante;
            int monto;
            if (residuo >= 100)
            {
                monto = obj.ValorEntrante / 100;
                residuo = obj.ValorEntrante % 100;
                newObj.ValorCien = monto;
            }
            if (residuo >= 50)
            {
                monto = residuo / 50;
                residuo %= 50;
                newObj.ValorCincuenta = monto;
            }
            if (residuo >= 20)
            {
                monto = residuo / 20;
                residuo %= 20;
                newObj.ValorVeinte = monto;
            }
            if (residuo >= 10)
            {
                monto = residuo / 10;
                newObj.ValorDiez = monto;
            }
            return newObj;
        }
    }
}