using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41b0_Paralelogramo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t Formando Obejto Rombo");
            
            string captura;
            do
            {
                Console.WriteLine("\n\n\t ¿Nombre?");
                captura = Console.ReadLine().Trim();
                if (captura == "")
                    Console.WriteLine("EL Nombre no puede estar vacío");
                else if (captura.Length > 8)
                    Console.WriteLine("El Nombre no puede tener un cadena mayo de 8 caracteres");
            } while (captura == string.Empty || captura.Length > 8);
            Rombo rb = new Rombo(captura, Util.CapturaEntero(" Lado base", 1, 200), Util.CapturaDouble("¿Angulo?", 1, 100));
            Console.WriteLine("\tNombre\tBase\tLateral\tAngulo\tPerim.\tArea");
            Console.WriteLine(rb.ComoString());
            Util.Pausa("Pulsa una tecla para continuar");
            Console.Clear();
            Console.WriteLine("\n\t\t Formando Obejto Rectangulo");

            string  capturaRg;
            do
            {
                Console.WriteLine("\n\n\t ¿Nombre?");
                capturaRg = Console.ReadLine().Trim();
                if (capturaRg == "")
                    Console.WriteLine("EL Nombre no puede estar vacío");
                else if (capturaRg.Length > 8)
                    Console.WriteLine("El Nombre no puede tener un cadena mayo de 8 caracteres");
            } while (capturaRg == string.Empty || capturaRg.Length > 8);
            Rectangulo rt = new Rectangulo(capturaRg, Util.CapturaEntero(" Lado ", 1, 200), Util.CapturaEntero(" Lado Base", 1, 200));
            Console.WriteLine("\tNombre\tBase\tLateral\tAngulo\tPerim.\tArea");
            Console.WriteLine(rt.ComoString());

            Util.Pausa("Pulsa una tecla para continuar");
            Console.Clear();
            Console.WriteLine("\n\t\t Formando Obejto Cuadrado");
            string capturaCd;
            do
            {
                Console.WriteLine("\n\n\t ¿Nombre?");
                capturaCd = Console.ReadLine().Trim();
                if (capturaCd == "")
                    Console.WriteLine("EL Nombre no puede estar vacío");
                else if (capturaCd.Length > 8)
                    Console.WriteLine("El Nombre no puede tener un cadena mayo de 8 caracteres");
            } while (capturaCd == string.Empty || capturaCd.Length > 8);
            Cuadrado cd = new Cuadrado(capturaCd, Util.CapturaEntero(" Lado Base", 1, 200));
            Console.WriteLine("\tNombre\tBase\tLateral\tAngulo\tPerim.\tArea");
            Console.WriteLine(cd.ComoString());

            Util.Pausa("Pulsa una tecla para continuar");
            Console.Clear();
            Console.WriteLine("\n\t\t Formando Obejto Romboide");
            string capturaRb;
            do
            {
                Console.WriteLine("\n\n\t ¿Nombre?");
                capturaRb = Console.ReadLine().Trim();
                if (capturaRb == "")
                    Console.WriteLine("EL Nombre no puede estar vacío");
                else if (capturaRb.Length > 8)
                    Console.WriteLine("El Nombre no puede tener un cadena mayo de 8 caracteres");
            } while (capturaRb == string.Empty || capturaRb.Length > 8);
            Romboide rbd = new Romboide(capturaRb, Util.CapturaEntero(" Lado Base", 1, 200), Util.CapturaEntero(" Lado ", 1, 200), Util.CapturaDouble("¿Angulo?", 1, 100));
            Console.WriteLine("\tNombre\tBase\tLateral\tAngulo\tPerim.\tArea");
            Console.WriteLine(rbd.ComoString());



            Console.ReadKey(true);
        }
    }
}
