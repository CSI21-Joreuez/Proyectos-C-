//Alumno: Orea, Juan Carlos

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
            string captura;
            char opcion;
            int numCuad=1, numRect=1, numRomboide=1, numRomb=1;
            List<Romboide> ListaFiguras = new List<Romboide>();
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
            opcion = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                switch (opcion)
             {
                    case '1':
                        Cuadrado cuadr = new Cuadrado("cuad-"+numCuad, Util.CapturaEntero("¿Lado Base?", 1, 200));
                        ListaFiguras.Add(cuadr);
                        numCuad++;
                        break;
                    case '2':
                        Rectangulo rt = new Rectangulo("rectn-"+numRect, Util.CapturaEntero(" ¿Lado? ", 1, 200), Util.CapturaEntero(" ¿Lado Base?", 1, 200));
                        ListaFiguras.Add(rt);
                        numRect++;
                        break;
                    case '3':
                        Rombo rb = new Rombo("romb-"+numRomb, Util.CapturaEntero(" ¿Lado Base?", 1, 200), Util.CapturaDouble("¿Angulo?", 1, 90));
                        ListaFiguras.Add(rb);
                        numRomb++;
                        break;
                    case '4':
                        Romboide rbd = new Romboide("roide-"+numRomboide, Util.CapturaEntero(" ¿Lado Base?", 1, 200), Util.CapturaEntero(" ¿Lado? ", 1, 200), Util.CapturaDouble("¿Angulo?", 1, 90));
                        ListaFiguras.Add(rbd);
                        numRomboide++;
                        break;

                    case '5':
                        Console.WriteLine("\tNombre\tBase\tLateral\tAngulo\tPerim.\tArea");
                        foreach (Romboide r in ListaFiguras)
                        {
                            Console.WriteLine(r.ComoString());
                        }
                        break;
              default:
                        Console.WriteLine("***ERROR EL VALOR INTRODUCIDO NO ESTÁ EN EL MENÚ***");
              break;     
                }
                Util.Pausa("Pulsa Una Tecla Para Volver al Menú");
            } while (opcion!='0');
            Util.Pausa("Pulsa una Tecla Para Salir...");
        }
    }
}
