// Alumno:

using System;
using System.Collections.Generic;

namespace PintarPiso
{
	public class PintarPisoApp
	{
		static void Main(string[] args)
		{
            CatalogoPinturas.AddPintura(new Pintura("Blanco", 4.5));
            CatalogoPinturas.AddPintura(new Pintura("Verde", 3.8));
            CatalogoPinturas.AddPintura(new Pintura("Salmón", 8.5));
            CatalogoPinturas.AddPintura(new Pintura("Beige", 7.2));
            CatalogoPinturas.AddPintura(new Pintura("Amarillo", 6.2));


            Piso p = new Piso("Bellavista 9 9ºB");
            p.listaRecintos.Add(new Habitacion("Salon", 20.5, 2, 3));
            p.listaRecintos.Add(new Habitacion("Dormi1", 15, 1, 1, 2));
            p.listaRecintos.Add(new Terraza("Terraza1", 4.0, 1, 1, 3, 10));

            int opcion;
            string nombre;
            double metros;
            int numPuertas;
            int numVentanas;
            int color;
            double mPretil;
            bool existe = false;
            string nombreRecinto;
            int elegir;
            int id =0 ;
            do
            {
                opcion = Util.Menu();
                Console.Clear();
                switch (opcion)
                {
                    case 1: // Mostrar las pinturas
                        CatalogoPinturas.Mostrar();
                        break;
                    case 2: // Mostrar los recintos y sus precios
                        p.MostrarRecintos();
                        break;
                    case 3: // Añadir Recinto
                        existe = false;
                        Console.Write("\t\t\nIntroduce Un Nombre Para El Recinto:  ");
                        nombre = Console.ReadLine();
                        if (nombre == String.Empty)
                        {
                            Console.WriteLine("El Nombre no se Puede Dejar en Blanco");
                            break;
                        }
                        foreach (Recinto h in p.listaRecintos)
                        {
                            if (nombre.ToUpper() == h.Nombre.ToUpper())
                            {
                                Console.WriteLine("***Error: No se Puede Introducir el Nombre de dos Habitaciones iguales***");
                                existe = true;
                                break;
                            }
                        }
                        if (!existe)
                        {
                            do
                            {
                                metros = Util.CapturaEntero("¿Metros de Pared?", 1, 1000);
                                numPuertas = Util.CapturaEntero("¿Número de Puertas?", 1, 100);
                                numVentanas = Util.CapturaEntero("¿Número de Ventanas?", 1, 100);
                                if (metros < 0.8 * numPuertas + numVentanas)
                                    Console.WriteLine("\n\n\t***ERROR NO CABEN TANTAS PUERTAS Y VENTANAS EN {0}M DE PARED", metros);

                            } while (metros < 0.8 * numPuertas + numVentanas);
                           

                            CatalogoPinturas.Mostrar();

                            color = Util.CapturaEntero("¿Color de la Pintura?",0,CatalogoPinturas.listaPinturas.Count-1);
                            if (Util.PreguntaSiNo("¿Es Una Terraza?"))
                            {
                                mPretil = Util.CapturaEntero("Introduce los metros de Petril", 1, 1000);
                                p.listaRecintos.Add(new Terraza(nombre, metros, numPuertas, numVentanas, color, mPretil));
                            }
                            else
                            {
                                p.listaRecintos.Add(new Habitacion(nombre, metros, numPuertas, numVentanas, color));
                            }

                        }

                        break;
                    case 4: // Eliminar Recinto
                        p.MostrarRecintos();
                        elegir = Util.CapturaEntero("Pulsa 1 para Borrar por el Nombre y 2 para borrar mediante el ID", 1, 2);
                        if (elegir == 1)
                        {
                            Console.WriteLine("¿Nombre del Recinto?");
                            nombreRecinto = Console.ReadLine();
                            for (int i = 0; i < p.listaRecintos.Count; i++)
                            {
                                if (nombreRecinto.ToUpper() == p.ListaRecintos[i].Nombre.ToUpper())
                                {
                                    Console.WriteLine("El Elemento {0} se ha borrado Correctamente ", nombreRecinto);
                                    p.listaRecintos.RemoveAt(i);
                                    break;
                                }
                                else if (nombreRecinto.ToUpper() != p.ListaRecintos[i].Nombre.ToUpper())
                                {
                                    Console.WriteLine("Error El Elemento no coincide con ningun elemento de la lista");
                                    break;
                                }

                            }
                        }
                        else if (elegir == 2)
                        {
                            foreach(Recinto h in p.listaRecintos)
                                Console.WriteLine("\n\t\t{0}\t{1}", ++id, h.Nombre);                                
                            id = -1 + Util.CapturaEntero("¿Indice del Recinto", 1, p.ListaRecintos.Count);
                            Console.WriteLine("El Elemento {0} se ha borrado Correctamente ", p.listaRecintos[id].Nombre);
                            p.listaRecintos.RemoveAt(id);

                        }
                        break;
                }
                if (opcion != 0)
                { 
                Console.WriteLine("\n\n\n\nPulsa una tecla para volver al Menú");
                Console.ReadKey();
                }
            } while (opcion != 0);

        }
	}
}
