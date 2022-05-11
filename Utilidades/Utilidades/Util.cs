using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
   public class Util
    {
        public static string CuadraTexto(string texto, int numChar)
        {
            texto += "                                                    ";
            texto = texto.Substring(0, numChar);
            return texto;
        }
        public static bool PreguntaSiNo(string texto)
        {
            bool error=false;
            bool repetir=false;
            char letra;
            
            do
            {
                Console.Write("/n/n/t{0}; [s=si || n=no]:",texto);
                letra = Console.ReadKey(true).KeyChar;
                if (letra == 's' || letra == 'S')
                    repetir = true;
                else if (letra == 'n' || letra == 'N')
                    repetir = false;
                else
                {
                    Console.WriteLine("/n/n/t***ERROR: INTRODUCE [S=SI || N=NO]***");
                    error = true;
                }

            } while (error);
            return repetir;
        }
        public static int CapturaEntero(string mensaje, int min, int max)
        {
            int num;
            bool esCorrecto;
            do
            {
                Console.Write(" {0} [{1}..{2}]: ", mensaje, min, max);
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
    }
}
