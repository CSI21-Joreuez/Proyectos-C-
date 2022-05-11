using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PintarPiso
{
    class CatalogoPinturas
    {
        public static List<Pintura> listaPinturas = new List<Pintura>();
        public static void Mostrar()   //<-- falta algo
        {
            Console.WriteLine("\n--------- PRESENTACION LISTA DE PINTURAS ----------\n");
            Console.WriteLine("\tid\tColor\tprecioM2");
            Console.WriteLine("\t--\t-----\t--------");
            for (int i = 0; i < listaPinturas.Count; i++)
            {
                Console.WriteLine("\t{0}\t{1}\t{2}",i,Util.CuadraTexto(listaPinturas[i].NombreColor,6),listaPinturas[i].PrecioM2);
            }

        }
        public static void AddPintura(Pintura p)
        { 
        listaPinturas.Add(p);
        }
    }
}
