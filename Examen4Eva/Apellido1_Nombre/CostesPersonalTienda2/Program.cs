using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostesPersonalTienda
{
	class Program
	{
        static void Main(string[] args)
        {



            int opcion = 0;

            do
            {
                opcion = Util.Menu();
                Console.Clear();

                switch (opcion)
                {
                    case 1:

                        break;

                    case 2:


                        break;

                    case 3:


                        break;

                    case 4:


                        break;

                    default: break;
                }


            } while (opcion != 0);

            Console.WriteLine("\n\n\t\tPulse una tecla para Salir");
            Console.ReadKey();

        }


    }
}
