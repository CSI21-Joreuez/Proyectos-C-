using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P33b3MostrarOrdenado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Construyo una lista donde guardar las líneas del fichero (registros)
            List<string> listaReg = new List<string>();

            // el StreamReader para leer los datos
            StreamReader sr = File.OpenText(@".\Datos\AlumNotas.txt");

            string registro;
            // Leemos todas las lineas del fichero y las guardamos en la lista
            while (!sr.EndOfStream)
            {
                registro = sr.ReadLine();
                Console.Write(registro.Substring(0, 3), 3);

                Console.Write(" {0} {1} ", registro.Substring(3, 28), registro.Substring(31, 9));

                Console.Write(" {2}/{1}/{0}  ", registro.Substring(40, 4), registro.Substring(44, 2), registro.Substring(46, 2));

                //--- la línea anterior equivaldría a estas dos:
                //registro = sr.ReadLine();
                //listaReg.Add(registro);
            }
            // ya hemnos leído todas las líneas, por lo tanto cierro el stream
            sr.Close();

            // por comodidad, guardo el tamaño de la lista (es decir, el número de alumnos), porque lo voy a usar varias veces
          /*  int numAlumnos = listaReg.Count;
            // construyo las tablas con el número de filas obtenidas
            byte[] tabIds = new byte[numAlumnos];
            string[] tabAlums = new string[numAlumnos];
            float[,] tabNotas = new float[numAlumnos, 3];

            // ahora vamos a rellenar las tres tablas desglosando las líneas que tengo en listaReg
            string[] vCampos; // <-- tabla donde guardaremos los campos de cada registro

            for (int i = 0; i < numAlumnos; i++)
            {
                vCampos = listaReg[i].Split(';');
                // en la primera posición de vCampos está el id: lo guardo en tabIds
                tabIds[i] = Convert.ToByte(vCampos[0]);
                // en la segunda posición de vCampos está el alumno: lo guardo en tabAlumnos
                tabAlums[i] = vCampos[1];
                // en las tres siguientes posiciones de vCampos están las tres notas
                tabNotas[i, 0] = Convert.ToSingle(vCampos[2]);
                tabNotas[i, 1] = Convert.ToSingle(vCampos[3]);
                tabNotas[i, 2] = Convert.ToSingle(vCampos[4]);

                //--- estas tres líneas equivalen al siguiente bucle
                //for (int j = 0; j < 3; j++)
                //   tabNotas[i, j] = Convert.ToSingle(vCampos[j + 2]);
            }

            //-------------- Mostramos los datos  -----------------
            double media;
            Console.WriteLine("     Id  Alumno\t\t\t\tProg    Ed      BD      Media");
            Console.WriteLine("     -----------------------------------------------------------------");
            //--- Versión 1: Cuadrando sólo el nombre
            //for (int i = 0; i < numAlumnos; i++)
            //{
            //             media = Math.Round((tabNotas[i, 0] + tabNotas[i, 1] + tabNotas[i, 2]) / 3, 2);
            //             Console.WriteLine("     {0} {1} {2}\t{3}\t{4}\t{5}", tabIds[i], CuadraTexto(tabAlums[i], 30), tabNotas[i, 0], tabNotas[i, 1], tabNotas[i, 2], media);
            //         }

            //--- Versión 2: Cuadrándolo todo
            //for (int i = 0; i < numAlumnos; i++)
            //{
            //    media = Math.Round((tabNotas[i, 0] + tabNotas[i, 1] + tabNotas[i, 2]) / 3, 2);
            //    Console.WriteLine("     {0} {1} {2}{3}{4}{5}", tabIds[i], 
            //        CuadraTexto(tabAlums[i], 30),
            //        CuadraTexto(tabNotas[i, 0].ToString(), 8),
            //        CuadraTexto(tabNotas[i, 1].ToString(), 8),
            //        CuadraTexto(tabNotas[i, 2].ToString(), 8),
            //        media.ToString());
            //}

            //--- Versión 3: Sin cuadrar pero  usando SetCursorPosition
            int filaPantalla = 2;
            for (int i = 0; i < numAlumnos; i++)
            {
                media = Math.Round((tabNotas[i, 0] + tabNotas[i, 1] + tabNotas[i, 2]) / 3, 2);
                Console.SetCursorPosition(5, filaPantalla);
                Console.Write("{0} {1}", tabIds[i], tabAlums[i]);
                Console.SetCursorPosition(40, filaPantalla);
                Console.Write("{0}\t{1}\t{2}\t{3}", tabNotas[i, 0], tabNotas[i, 1], tabNotas[i, 2], media);
                filaPantalla++;
            }*/

            Console.WriteLine("\n\n\t Pulsa tecla para salir");
            Console.ReadKey();
        }

        static string CuadraTexto(string texto, int numCaracteres)
        {
            texto += ".................................";
            return texto.Substring(0, numCaracteres);
        }
    }
}
