//Alumno: Orea, Juan Carlos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41b4_Paralelogramo
{
    class Program
    {
        static void Main(string[] args)
        {
            string captura;
            int opcion;
            string nombre= string.Empty;
            int ladoBase = 0, ladoLateral = 0, angulo = 0;
            int[] vContadores = { 0, 0, 0, 0, 0 };
            string[] vFiguras = {"", "cuad-", "rectn-", "romb-", "roide-" };
            List<Paralelogramo> ListaFiguras = new List<Paralelogramo>();
            do
            {
            captura=string.Empty;
            Console.Clear();
            Console.WriteLine("\n\n\t\t╔═══════════════════════════════════════════╗");
            Console.WriteLine("\t\t║           Menú Paralelogramos             ║");
            Console.WriteLine("\t\t╠═══════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                           ║");
            Console.WriteLine("\t\t║   1) Construir Cuadrado                   ║");
            Console.WriteLine("\t\t║                                           ║");
            Console.WriteLine("\t\t║   2) Construir Rectangulo                 ║");
            Console.WriteLine("\t\t║                                           ║");
            Console.WriteLine("\t\t║   3) Construir Rombo                      ║");
            Console.WriteLine("\t\t║                                           ║");
            Console.WriteLine("\t\t║   4) Construir Romboide                   ║");
            Console.WriteLine("\t\t║                                           ║");
            Console.WriteLine("\t\t║   5) Presentar Paralelogramos             ║");
            Console.WriteLine("\t\t║___________________________________________║");
            Console.WriteLine("\t\t║           0) Salir                        ║");
            Console.WriteLine("\t\t╚═══════════════════════════════════════════╝");
            Console.Write("\t\tIntroduce una opción: ");
            opcion = Console.ReadKey().KeyChar -'0';
                if (opcion > 0 && opcion < 5)
                {
                    vContadores[opcion]++;
                    nombre = Util.CuadraTexto(vFiguras[opcion] + vContadores[opcion], 8);
                    Console.WriteLine("\n\t--- Parametros para contruir {0}---",nombre);
                    ladoBase = Util.CapturaEntero("\n\n\t¿Lado Base?", 1, 100);
                }
                Console.WriteLine("\n");
                switch (opcion)
             {
                    case 1:
                        ListaFiguras.Add(new Cuadrado(nombre,ladoBase));
                        break;
                    case 2:
                        ladoLateral = Util.CapturaEntero("¿Lado Lateral?", 1, 100);
                        ListaFiguras.Add(new Rectangulo(nombre,ladoLateral,ladoBase));
                        break;
                    case 3:
                        angulo = Util.CapturaEntero("¿Angulo? ",1, 90);
                        ListaFiguras.Add(new Rombo(nombre,ladoBase,angulo));
                        break;
                    case 4:
                        angulo = Util.CapturaEntero("¿Angulo? ", 1, 90);
                        ListaFiguras.Add(new Romboide(nombre,ladoBase,ladoLateral,angulo));
                        break;

                    case 5:
                        Console.WriteLine("\tNombre\tBase\tLateral\tAngulo\tPerim.\tArea");
                        foreach (Paralelogramo r in ListaFiguras)
                        {
                            Console.WriteLine(r.ToString());
                        }
                        break;
              default:
                        Console.WriteLine("***ERROR EL VALOR INTRODUCIDO NO ESTÁ EN EL MENÚ***");
              break;     
                }
                Util.Pausa("Pulsa Una Tecla Para Volver al Menú");
            } while (opcion!=0);
            Util.Pausa("Pulsa una Tecla Para Salir...");
        }
    }
}
