// Nota: Lo que tienes escrito aquí es orientativo. Puedes quitar o poner lo que te interese.

using System;
using System.Collections;

namespace CostesPersonalTienda
{
    public class Util
    {
        //----DEVUELVE LA OPCION SELECCIONADA
        public static int Menu()
        {
            int opcion=0;

                Console.Clear();
                Console.WriteLine("\n\n\n\t\t\tAlumno: Nombre Apellido1");
                Console.WriteLine("\t\t\t╔════════════════════════════════╗");
                Console.WriteLine("\t\t\t║             MENU               ║");
                Console.WriteLine("\t\t\t╠════════════════════════════════╣");
                Console.WriteLine("\t\t\t║                                ║");
                Console.WriteLine("\t\t\t║    1) Puestos de trabajo       ║");
                Console.WriteLine("\t\t\t║    2) Costes Mensuales         ║");
                Console.WriteLine("\t\t\t║                                ║");
                Console.WriteLine("\t\t\t║    3) Alta de Empleada         ║");
                Console.WriteLine("\t\t\t║    4) Baja de Empleada         ║");
                Console.WriteLine("\t\t\t║                                ║");
                Console.WriteLine("\t\t\t║           0) Salir             ║");
                Console.WriteLine("\t\t\t║                                ║");
                Console.WriteLine("\t\t\t╚════════════════════════════════╝");

                //-- Capturo la pulsación

            return opcion;
        }

        public static int CapturaEntero(string frase, int min, int max)
        {
            int num=0;

            return num;
        }


        // Devuelve true si pulsas s ó S. Devuelve false si pulsas n ó N
        public static bool PreguntaSioNo(string frase)
        {
            // ...

            return false;
        }

        /// <summary>
        /// Cuadra el texto que recibe a la izquierda de una cadena de longitud «numCaracteres»
        /// rellenando a la derecha con el caracter de relleno
        /// </summary>
        /// <param name="texto">Cadena a cuadrar</param>
        /// <param name="numCaracteres">Número de caracteres de la cadena de salida</param>
        /// <param name="relleno">Carácter con que se rellenará a la derecha</param>
        /// <returns>Cadena resultante</returns>
        public static string CuadraTexto(string texto, int numCaracteres, char relleno)
        {

            return texto; //<-- Aquí falta algo
        }

        /// <summary>
        /// Devuelve el número como una cadena cuadrada a la derecha de longitud «numCaracteres»
        /// </summary>
        /// <param name="numero">Número a cuadrar</param>
        /// <param name="numCaracteres">Longitud total de la cadena que devuelve</param>
        /// <returns>Devuelve la cadena de longitud «numCaracteres» con el número ajustado a la derecha</returns>
        public static string CuadraTexto(double numero, int numCaracteres)
        {
            string cadena = "                      ";

            return cadena;  //<-- Aquí falta algo
        }

        /// <summary>
        /// Muestra el texto que recibe con el color de fondo en DarkRed
        /// </summary>
        /// <param name="texto"></param>
        public static void Error(string texto)
        {

            Console.WriteLine(" ** {0} ** ", texto);

        }

    }
}
