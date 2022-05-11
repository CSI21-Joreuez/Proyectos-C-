//Alumno: Orea,Juan Carlos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40e1_ProyRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("\tNombre\t\tLB\tLT\tP\tA");
            Rectangulo rc = new Rectangulo("Rectan-1", 10, 20);
            Console.WriteLine("\t" + rc.Nombre + "\t" + rc.LadoBase + "\t" + rc.LadoLateral + "\t" + rc.Perimetro + "\t" + rc.Area);
            Console.WriteLine("\t---------------------------------------------");
            while (Util.PreguntaSiNo("Quieres Modificar"))
            {
                Console.Write("\n\tIntroduce el Nombre: ");
                string nombre = Console.ReadLine();
                while (nombre == string.Empty)
                {

                    Console.WriteLine("\tError, No puedes dejar el Nombre en Blanco ");
                    Console.Write("\tIntroduce el Nombre: ");
                    nombre = Console.ReadLine();
                }
                while (nombre.Length > 8)
                {

                    Console.WriteLine("\tError, El nombre no puede tener mas de 8 caracteres de longitud ");
                    Console.Write("\tIntroduce el Nombre: ");
                    nombre = Console.ReadLine();
                }
                int lado = Util.CapturaEntero("Introduce la longitud de un lado", 1, 100);
                int ladoBase = Util.CapturaEntero("Introduce la longitud de la base", 1, 100);
                Console.Clear();
                Console.WriteLine("\tNombre\tLB\tLT\t\tP\tA");
                Console.WriteLine(rc.RectanguloAString(nombre, ladoBase, lado, (lado + ladoBase) * 2, ladoBase * lado));
                Console.WriteLine("\t---------------------------------------------");

                Console.ReadKey(true);
            }*/

            bool modificar;
            Rectangulo rl = new Rectangulo("Rectan-1", 10, 20);
            do
            {

            Console.Clear();
                Console.WriteLine("\n\tNombre  \tBase \tL \tP.\tArea");
                Console.WriteLine(" \t------\t\t----- \t---  ----- \t----- ");
                Console.WriteLine(rl.RectanguloAString());
                modificar = Util.PreguntaSiNo("¿Quieres Modificar?");
                if (modificar)
                Modificarectangulo(rl);
            } while (modificar);
            Console.WriteLine("\nPulsa para Salir");
            Console.ReadKey(true);

        }

        private static void Modificarectangulo(Rectangulo rl)
        {
            string captura;
            do
            {
                Console.WriteLine("\n\n\t ¿Nuevo Nombre?");
                captura = Console.ReadLine().Trim();
                if (captura == "")
                    Console.WriteLine("EL Nombre no puede estar vacío");
                else if (captura.Length > 8)
                    Console.WriteLine("El Nombre no puede tener un cadena mayo de 8 caracteres");
            } while (captura == string.Empty || captura.Length > 8);
            rl.Nombre = captura;
            rl.LadoBase = Util.CapturaEntero("Nuevo Lado base", 1, 100);
            rl.LadoLateral = Util.CapturaEntero("Nuevo Lado Lateral", 1, 100);
        }
    }
}
