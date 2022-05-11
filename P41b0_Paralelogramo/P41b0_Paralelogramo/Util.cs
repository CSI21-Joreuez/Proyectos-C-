using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41b0_Paralelogramo
{
    class Util
    {
        public static bool PreguntaSiNo(string pregunta)
        {
            char tecla;

            do
            {
                // Hacemos la pregunta
                Console.Write("{0} (s=Sí; n=No): ", pregunta);
                // Capturamos la respuesta (una pulsación)
                tecla = (Console.ReadKey()).KeyChar;
                if (tecla == 's' || tecla == 'S')
                    return true;
                if (tecla == 'n' || tecla == 'N')
                    return false;
                // Si llega aquí es que no ha pulsado ninguna de las teclas correctas
                Console.Write("\n\n\t** Error: por favor, responde S o N **");

            } while (true);
        }
        public static string CuadraTexto(string texto, int numCaracteres)
        {
            texto += "                                      ";
            return texto.Substring(0, numCaracteres);
        }
        public static int CapturaEntero(string texto, int min, int max)
        {
            int num;
            bool esCorrecto;
            do
            {
                Console.Write(" {0} [{1}..{2}]: ", texto, min, max);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out num);
                if (!esCorrecto)
                    Console.WriteLine("\n\t ** ERROR de FORMATO **");
                else if (num < min || num > max)
                {
                    Console.WriteLine(" ** ERROR: VALOR FUERA DE RANGO **");
                    esCorrecto = false;
                }
            } while (!esCorrecto);

            return num;
        }
        public static double CapturaDouble(string texto, double min, double max)
        {
            double num;
            bool esCorrecto;
            do
            {
                Console.Write(" {0} [{1}..{2}]: ", texto, min, max);
                esCorrecto = Double.TryParse(Console.ReadLine(), out num);
                if (!esCorrecto)
                    Console.WriteLine("\n\t ** ERROR de FORMATO **");
                else if (num < min || num > max)
                {
                    Console.WriteLine(" ** ERROR: VALOR FUERA DE RANGO **");
                    esCorrecto = false;
                }
            } while (!esCorrecto);

            return num;
        }
        public static void Pausa(string texto)
        {
            Console.WriteLine("\n\n\t{0}",texto);
            Console.ReadKey(true);
        }

    }
}
