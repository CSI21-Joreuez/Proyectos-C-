using System;
using System.Collections.Generic;

namespace PintarPiso
{
    public class Util
    {
        //----DEVUELVE LA OPCION SELECCIONADA
        public static int Menu()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\t\t\tAlumno: ");
                Console.WriteLine("\t\t\t╔══════════════════════════════╗");
                Console.WriteLine("\t\t\t║             MENU             ║");
                Console.WriteLine("\t\t\t╠══════════════════════════════╣");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t║    1.- Lista de pinturas     ║");
                Console.WriteLine("\t\t\t║    2.- Presentar Precios     ║");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t║    3.- Añadir Recinto        ║");
                Console.WriteLine("\t\t\t║    4.- Eliminar Recinto      ║");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t║          0) Salir            ║");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t╚══════════════════════════════╝");
                Console.Write("\t\t\t¿Opción?");
                opcion = Console.ReadKey().KeyChar - '0';
            } while (opcion < 0 || opcion > 4);

            return opcion;
        }
        public static string CuadraTexto(String texto, int numChar)
        {
            texto += "                                       ";
            return texto.Substring(0, numChar);
        
        }
        public static string CuadraTextoDerecha(String texto, int numChar)
        {
            texto = "                                   " + texto.Trim();
            return texto.Substring(0, numChar);
        }
        
        public static bool PreguntaSiNo(string texto)
        {
            char respuesta;
            bool repetir = false;
            bool error = true;
            do
            {


                Console.Write("\n\n\t{0}; Reponde con s=si || n=no:", texto);
                respuesta = Console.ReadKey(true).KeyChar;
                if (respuesta == 's' || respuesta == 'S')
                {
                    repetir = true;
                    error = false;
                }
                else if (respuesta == 'n' || respuesta == 'N')
                {
                    repetir = false;
                    error = false;
                }
                else
                {
                    error = true;
                    Console.WriteLine("***Error Introduce s || n***");
                }
            } while (error);
            return repetir;
        }

        public static int CapturaEntero(string mensaje, int min, int max)
        {
            int valor = 0;
            bool esCorrecto = false;
            do
            {
                Console.Write("\n{0} ({1}..{2}): ", mensaje, min, max);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
                if (!esCorrecto || valor < min || valor > max)
                    Console.WriteLine(" ** Error ** Debe ser un entero de {0} a {1}  **", min, max);
            }
            while (!esCorrecto || valor < min || valor > max);

            return valor;
        }



    }
}
