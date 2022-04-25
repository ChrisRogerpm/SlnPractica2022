using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabajoFinal_I_Unidad.Models
{
    public class Ejercicio03
    {
        public int ValorDoscientos { get; set; }
        public int ValorCien { get; set; }
        public int ValorCincuenta { get; set; }
        public int ValorVeinte { get; set; }
        public int ValorDiez { get; set; }
        public int ValorTotalBilletes { get; set; }
        public int ValorCinco { get; set; }
        public int ValorDos { get; set; }
        public int ValorUno { get; set; }
        public int ValorCeroCincuenta { get; set; }
        public int ValorCeroVeinte { get; set; }
        public int ValorCeroDiez { get; set; }
        public int ValorCeroCinco { get; set; }
        public int ValorCeroUno { get; set; }
        public int ValorTotalMonedas { get; set; }
        public int ValorResiduo { get; set; }
        public static ClassRespuesta CalcularOperacion(Ejercicio03 obj)
        {
            ClassRespuesta objRespuesta = new ClassRespuesta();
            List<List<double>> ListaNumeros = new List<List<double>>();
            ListaNumeros.Add(new List<double>() { 200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.1 });
            objRespuesta.Estado = false;
            if (obj.ValorDoscientos % 200 > 0)
            {
                objRespuesta.Mensaje = "El monto de denominación 200 no es valido";
                objRespuesta.Estado = true;
                return objRespuesta;
            }
            if (obj.ValorCien % 100 > 0)
            {
                objRespuesta.Mensaje = "El monto de denominación 100 no es valido";
                objRespuesta.Estado = true;
                return objRespuesta;
            }
            if (obj.ValorCincuenta % 50 > 0)
            {
                objRespuesta.Mensaje = "El monto de denominación 50 no es valido";
                objRespuesta.Estado = true;
                return objRespuesta;
            }
            if (obj.ValorVeinte % 20 > 0)
            {
                objRespuesta.Mensaje = "El monto de denominación 20 no es valido";
                objRespuesta.Estado = true;
                return objRespuesta;
            }
            if (obj.ValorDiez % 10 > 0)
            {
                objRespuesta.Mensaje = "El monto de denominación 10 no es valido";
                objRespuesta.Estado = true;
                return objRespuesta;
            }
            if (obj.ValorCinco % 5 > 0)
            {
                objRespuesta.Mensaje = "El monto de denominación 5 no es valido";
                objRespuesta.Estado = true;
                return objRespuesta;
            }
            if (obj.ValorDos % 2 > 0)
            {
                objRespuesta.Mensaje = "El monto de denominación 2 no es valido";
                objRespuesta.Estado = true;
                return objRespuesta;
            }
            if (obj.ValorUno % 1 > 0)
            {
                objRespuesta.Mensaje = "El monto de denominación 1 no es valido";
                objRespuesta.Estado = true;
                return objRespuesta;
            }
            if (obj.ValorCeroCinco % 0.5 > 0)
            {
                objRespuesta.Mensaje = "El monto de denominación 0.5 no es valido";
                objRespuesta.Estado = true;
                return objRespuesta;
            }
            if (obj.ValorCeroUno % 0.1 > 0)
            {
                objRespuesta.Mensaje = "El monto de denominación 0.1 no es valido";
                objRespuesta.Estado = true;
                return objRespuesta;
            }
            objRespuesta.TotalBilletes = obj.ValorDoscientos + obj.ValorCien + obj.ValorCincuenta + obj.ValorVeinte + obj.ValorDiez;
            objRespuesta.TotalMonedas = obj.ValorCinco + obj.ValorDos + obj.ValorUno + obj.ValorCeroCinco + obj.ValorCeroVeinte + obj.ValorCeroDiez + obj.ValorCeroCinco + obj.ValorCeroUno;
            double totalfinal = objRespuesta.TotalBilletes + objRespuesta.TotalMonedas;
            objRespuesta.ResultadoTexto = Conversores.NumeroALetras((decimal)totalfinal);
            return objRespuesta;
        }
    }
    public class ClassRespuesta
    {
        public string Mensaje { get; set; }
        public double TotalBilletes { get; set; }
        public double TotalMonedas { get; set; }
        public decimal Resultado { get; set; }
        public string ResultadoTexto { get; set; }
        public bool Estado { get; set; }
    }
}