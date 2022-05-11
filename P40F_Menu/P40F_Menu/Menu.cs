using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40F_Menu
{
    public class Menu
    {
        string[] vMenu = new string[9];
        
        public Menu(string[] vMenu)
        {
            this.vMenu = vMenu;
        }
        public string[] VMenu { get => vMenu; set => vMenu = value; }

        public static int Presentar()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t\t╔═════════════════════╗");
            Console.WriteLine("\t\t\t║        MENÚ         ║");
            Console.WriteLine("\t\t\t╠═════════════════════╣");
            Console.WriteLine("\t\t\t║     1) Abrir        ║");
            Console.WriteLine("\t\t\t║     2) Cerrar       ║");
            Console.WriteLine("\t\t\t║                     ║");
            Console.WriteLine("\t\t\t║     3) Bloquear     ║");
            Console.WriteLine("\t\t\t║     4) Desbloquear  ║");
            Console.WriteLine("\t\t\t║                     ║");
            Console.WriteLine("\t\t\t║     5) Pintar       ║");
            Console.WriteLine("\t\t\t║                     ║");
            Console.WriteLine("\t\t\t║     6) Eliminar     ║");
            Console.WriteLine("\t\t\t║                     ║");
            Console.WriteLine("\t\t\t║  7) Fabricar Puerta ║");
            Console.WriteLine("\t\t\t║  8) Fabricar Portón ║");
            Console.WriteLine("\t\t\t║                     ║");
            Console.WriteLine("\t\t\t║     9) Mostrar      ║");
            Console.WriteLine("\t\t\t║_____________________║");
            Console.WriteLine("\t\t\t║                     ║");
            Console.WriteLine("\t\t\t║     0) Salir        ║");
            Console.WriteLine("\t\t\t╚═════════════════════╝");

            return Util.CapturaNumPulsado("\t\t\tPulse su opción", 0, 9);
        }
    }
}
