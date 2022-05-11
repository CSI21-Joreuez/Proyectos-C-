using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P45a_PilotarAvion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Avion av = new Avion("Jett","AR-15","JOREUEX");
            int opcion;
            do
            {
                Console.WriteLine("\t\t\t╔════════════════════════════╗");
                Console.WriteLine("\t\t\t║ Opciones del Piloto        ║");
                Console.WriteLine("\t\t\t╠════════════════════════════╣");
                Console.WriteLine("\t\t\t║ 1) Aumentar Velocidad      ║");
                Console.WriteLine("\t\t\t║ 2) Disminuir Velocidad     ║");
                Console.WriteLine("\t\t\t║ 3) Despegar                ║");
                Console.WriteLine("\t\t\t║ 4) Aumentar Altitud        ║");
                Console.WriteLine("\t\t\t║ 5) Disminuir Altitud       ║");
                Console.WriteLine("\t\t\t║ 6) Aterrizar               ║");
                Console.WriteLine("\t\t\t║============================║");
                Console.WriteLine("\t\t\t║ 0) Salir                   ║");
                Console.WriteLine("\t\t\t║                            ║");
                Console.WriteLine("\t\t\t╚════════════════════════════╝");
                opcion = Console.ReadKey().KeyChar - '0';


            } while (opcion !=0);
            
        }
    }
}
