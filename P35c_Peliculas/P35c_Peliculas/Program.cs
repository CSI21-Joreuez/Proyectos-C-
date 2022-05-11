using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P35c_Peliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vVector;
            Console.WriteLine("Nº     Pelicula\t\t\t\tValor     Form.     Tamaño");
            Console.WriteLine("---   -------------------------------   ----      -----     ------");
            StreamReader sr = new StreamReader(@".\Datos\pelis.TXT");
            while (!sr.EndOfStream)
            {
               
            
            }
            Pausa();

        }
        static void Pausa()
        {
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey(true);
        }
        static string CuadraTexto(string texto, int numCaracteres)
        {
            texto += "                                      ";
            return texto.Substring(0, numCaracteres);
        
        }
    }
}
