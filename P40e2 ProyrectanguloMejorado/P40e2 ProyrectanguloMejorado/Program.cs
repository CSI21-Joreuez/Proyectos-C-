using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40e2_ProyrectanguloMejorado
{
    class Program
    {
        static void Main(string[] args)
        {
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
