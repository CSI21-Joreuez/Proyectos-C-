//Alumno: Orea, Juan Carlos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40F_Menu
{
    class Util
    {
        public static bool PreguntaSiNo(string pregunta)
        {
            char tecla;

            do
            {
                Console.Write("{0} (s=Sí; n=No): ", pregunta);
                tecla = (Console.ReadKey()).KeyChar;
                if (tecla == 's' || tecla == 'S')
                    return true;
                if (tecla == 'n' || tecla == 'N')
                    return false;
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
        public static int CapturaNumPulsado(string texto, int min, int max)
        {
            int valor = 0;
            char letra;
            do
            {
                Console.WriteLine("{0} [{1}...{2}]", texto, min, max);
                letra = Console.ReadKey().KeyChar;
                valor = letra - '0';
                if (valor < min || valor > max)
                {
                    Console.WriteLine(" ** NO VALIDO. ({0} a {1})", min, max);
                    Console.Beep(400, 400);
                }
            } while (valor < min || valor > max);
            return valor;
        }

    }
}
