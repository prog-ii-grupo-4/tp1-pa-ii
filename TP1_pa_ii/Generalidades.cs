using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TP1_pa_ii
{
    public static class Generalidades
    {
        // 1) Crear una función que devuelva la suma de dos números recibidos por parámetros
        public static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        /* 2) Crear una función que reciba una cadena de 8 caracteres y retorne en el mismo parámetro la cadena
        cortada de izquierda a derecha en 4 caracteres */
        public static string CortarString(string palabra)
        {
            return palabra.Substring(0, 4);
        }

        // 3) Crear una función que devuelva la fecha y hora actual
        public static DateTime MostrarFechaActual()
        {
            return DateTime.Now;
        }

        // Agregar a la enumeración la posibilidad de Imprimir un Texto por cada día de la semana
        public static string MostrarDiaDeLaSemana(DiasDeLaSemana dia)
        {
            switch(dia)
            {
                case DiasDeLaSemana.Domingo:
                    return "Domingo";
                case DiasDeLaSemana.Lunes:
                    return "Lunes";
                case DiasDeLaSemana.Martes:
                    return "Martes";
                case DiasDeLaSemana.Miercoles:
                    return "Miércoles";
                case DiasDeLaSemana.Jueves:
                    return "Jueves";
                case DiasDeLaSemana.Viernes:
                    return "Viernes";
                case DiasDeLaSemana.Sabado:
                    return "Sábado";
                default:
                    return "Error";
            }
        }
    }
}
