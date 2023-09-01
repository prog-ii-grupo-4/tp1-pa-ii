namespace TP1_pa_ii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- GENERALIDADES ----\n");

            Console.WriteLine("*Punto 1 - Función que devuelve la suma de dos números recibidos por parámetros");
            Console.WriteLine("Ingrese primer número:");
            int valor1;
            Int32.TryParse(Console.ReadLine(), out valor1);
            
            Console.WriteLine("Ingrese segundo número:");
            int valor2;
            Int32.TryParse(Console.ReadLine(), out valor2);

            Console.WriteLine("Resultado: " + Generalidades.Sumar(valor1, valor2));

            Console.WriteLine("\n*Punto 2 - Función que recibe una cadena de 8 caracteres y la retorna cortada de izquierda a derecha en 4 caracteres.");
            Console.WriteLine("Palabra: acertado");
            string palabra = "acertado";
            Console.WriteLine("Resultado: " + Generalidades.CortarString(palabra));

            Console.WriteLine("\n*Punto 3 - Crear una función que devuelva la fecha y hora actual.");
            Console.WriteLine(Generalidades.MostrarFechaActual());

            Console.WriteLine("\n\nPresione una tecla para cargar las conversiones...");
            Console.ReadKey(true);

            Console.WriteLine("\n---- CONVERSIONES ----\n");

            Console.WriteLine("*Punto 1 - Conversión Convert., bool.Parse, bool.TryParse");

            Console.WriteLine("\nAl enviar true:");
            Console.WriteLine(Convert.ToBoolean("true")); // devuelve True
            Console.WriteLine(bool.Parse("true")); // devuelve True
            bool result1;
            bool.TryParse("true", out result1); // devuelve True
            Console.WriteLine(result1);

            Console.WriteLine("\nAl enviar false:");
            Console.WriteLine("\n" + Convert.ToBoolean("false")); // devuelve False
            Console.WriteLine(bool.Parse("false")); // devuelve False
            bool result2;
            bool.TryParse("false", out result2); // devuelve False
            Console.WriteLine(result2);

            Console.WriteLine("\nAl enviar 1:");
            Console.WriteLine("Arroja excepción: 'String '1' was not recognized as a valid Boolean.");
            Console.WriteLine("Arroja excepción: 'String '1' was not recognized as a valid Boolean.");
            //Console.WriteLine(Convert.ToBoolean("1")); // arroja excepción: 'String '1' was not recognized as a valid Boolean.'
            //Console.WriteLine(bool.Parse("1")); // arroja excepción: 'String '1' was not recognized as a valid Boolean.'
            bool result3;
            bool.TryParse("1", out result3);
            Console.WriteLine(result3); // devuelve False

            Console.WriteLine("\nAl enviar 0:");
            Console.WriteLine("Arroja excepción: 'String '1' was not recognized as a valid Boolean.");
            Console.WriteLine("Arroja excepción: 'String '1' was not recognized as a valid Boolean.");
            //Console.WriteLine(Convert.ToBoolean("0")); // arroja excepción: 'String '0' was not recognized as a valid Boolean.'
            //Console.WriteLine(bool.Parse("0")); // arroja excepción: 'String '0' was not recognized as a valid Boolean.'
            bool result4;
            bool.TryParse("0", out result4);
            Console.WriteLine(result4); // devuelve False

            Console.WriteLine("\n*Punto 2a. Valor inicial: 344.4");
            Console.WriteLine(Conversiones.Punto2a());
            Console.WriteLine("Muestra solo el valor entero al castear a int.");

            Console.WriteLine("\n*Punto 2b. Valor inicial: 10");
            Console.WriteLine(Conversiones.Punto2b());
            Console.WriteLine("El valor se muestra correctamente pero ahora asignado como 'decimal'.");

            Console.WriteLine("\n*Punto 2c. Valor inicial: 443444");
            Console.WriteLine(Conversiones.Punto2c());
            Console.WriteLine("El valor cambió al castear de int a short.");

            Console.WriteLine("\n*Punto 3 - Escriba una sentencia switch utilizando una enumeración con 3 colores (blanco, azul y negro) y para cada caso indicar un mensaje de cual es el color informado.");
            Console.WriteLine(Conversiones.InformarColor(Colores.Azul));

            Console.WriteLine("\n*Punto 4 y 5 - Sentencia if para evaluar si la variable a es mayor a 10.");
            Console.WriteLine("Ingrese un número entero:");
            int punto4;
            Int32.TryParse(Console.ReadLine(), out punto4);
            Console.WriteLine("Resultado: " + Conversiones.EvaluarMayorA10(punto4));

            Console.WriteLine("\n*Punto 6 - ¿Cuál es la diferencia entre la sentencia for y foreach?");
            Console.WriteLine("\nLa diferencia entre 'for' y 'foreach' es que el primero permite iterar un numero determinado de veces y se suele utilizar para manejar índices de colecciones en cada iteración.");
            Console.WriteLine("En cambio, el foreach no maneja índices sino que directamente va iterando elemento a elemento de una colección ya existente y la cantidad de veces que vaya a iterar depende de la longitud de esa colección.");

            Console.WriteLine("\n*Punto 7 - Defina una variable a que en cada ciclo de una sentencia while incremente su valor en 5. Cuando exceda el valor de 50, el ciclo while debe finalizar.");
            Console.WriteLine(Conversiones.SentenciaWhile());
        }
    }
}