using System;
using System.Collections.Generic;

namespace PintarPiso
{
	class Piso
	{
        string direccion;

        public Piso(string direccion)
        {
            this.direccion = direccion;
        }

        public string Direccion { get => direccion; set => direccion = value; }
        public List<Recinto> ListaRecintos { get => listaRecintos; set => listaRecintos = value; }

        //...
        public List<Recinto> listaRecintos = new List<Recinto>();


        public void MostrarRecintos()
        {
            double suma = 0;
            // cabecera
            Console.WriteLine("\n   -- Precio de pintura del piso: {0} --\n", direccion);
            Console.WriteLine("   Recinto    ------ PARED -------      -- PINTURA --   PRETIL    TOTAL");
            Console.WriteLine("   Nombre     metros   nºP     nºV      Color  Precio   metros    Precio");
            Console.WriteLine("   -------    ------   ---     ---      -----  ------   ------    ------");
            foreach (Recinto h in listaRecintos)
            { 
            suma+=h.MuestraPrecioPintura();
            }
            Console.WriteLine("                                                                  ------");
            Console.WriteLine("                                             TOTAL Euros Pintura: {0}", suma);

        }

    }
}
