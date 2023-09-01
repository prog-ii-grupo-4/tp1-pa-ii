using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_pa_ii
{
    public static class Conversiones
    {
        // 2) Explique que sucede en los siguientes intentos de casteos de datos
        public static int Punto2a()
        {
            int a = (int)344.4;
            return a; // el valor de a muestra solo el valor entero
        }

        public static decimal Punto2b()
        {
            decimal a = 10;
            return a; // el valor de a se muestra correctamente
        }

        public static short Punto2c()
        {
            int a = 443444;
            short b = (short)a;

            return b; // el valor de b muestra -15308
        }

        /* 3) Escriba una sentencia switch utilizando una enumeración con 3 colores (blanco, azul y negro) y para
        cada caso indicar un mensaje de cual es el color informado */
        public static string InformarColor(Colores color)
        {
            switch(color)
            {
                case Colores.Blanco:
                    return "Color blanco";
                case Colores.Azul:
                    return "Color azul";
                case Colores.Negro:
                    return "Color negro";
                default:
                    return "Ningún color seleccionado";
            }
        }

        /* 4) Si se tiene una variable entera a, realice una sentencia if para evaluar si la variable a es mayor a 10.
        Si es verdad, mostrar un mensaje indicando que el valor es mayor a 10
        5) Al ejercicio del punto 4), agregar la sentencia de else y, en ella, indicar un mensaje de error */
        public static string EvaluarMayorA10(int a)
        {
            if (a > 10)
                return "El valor de a es mayor a 10";
            else
                return "Error, el valor es menor o igual a 10";
        }

        /* 6) La diferencia entre 'for' y 'foreach' es que el primero permite iterar un numero determinado de veces
         y se suele utilizar para manejar índices de colecciones en cada iteración.
         En cambio, el foreach no maneja índices sino que directamente va iterando elemento a elemento de una colección ya existente
        y la cantidad de veces que vaya a iterar depende de la longitud de esa colección. */

        /* 7) Defina una variable a que en cada ciclo de una sentencia while incremente su valor en 5. Cuando la
        variable a exceda el valor de 50, el ciclo while debe finalizar */
        public static int SentenciaWhile()
        {
            int a = 0;

            while (a <= 50)
            {
                a = a + 5;
            }

            return a;
        }
    }
}
