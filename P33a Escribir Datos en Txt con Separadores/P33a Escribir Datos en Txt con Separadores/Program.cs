using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P33a_Escribir_Datos_en_Txt_con_Separadores
{
    class Program
    {
        
        static void Main(string[] args)
        {


            string[] tApell = { "Sánchez Elegante", "Arenas Mata", "García Solís", "Rodríguez Vázquez", "Hurtado Miranda", "Pinto Mirinda", "Barrios Garrobo", "Márquez Salazar", "Medina Gómez", "Alonso Pérez", "López Mora", "González Chaparro", "Ferrer Jiménez", "Morales Moncayo", "Fernández Perea", "Blanco Roldán", "Navarro Romero", "Aguilar Rubio", "Baena Fernández", "Barco Ramírez", "Delegado Rodríguez", "Duque Martínez" };
            string[] tNombre = {"Álvaro", "Daniel Luis", "Juan Manuel", "Agustín", "Fco. Javier", "José Manuel", "María", "Carlos",
            "Jose Carlos", "Juan Luis", "Daniel", "Carmen", "Jacobo", "Alejandro", "Francisco", "Alicia", "Francisco", "Ángela",
            "Constantino", "Mariló", "Rafaela", "Antonio" };

            int tamanyo = tApell.Length;

            byte[] tablaIds = CargaIds2Cifras(tamanyo);

            float[,] tNotas = Carga3Notas(tamanyo);

            StreamWriter sw = File.CreateText(@"C:\Datos\fNotasCS.TXT");

            //En Este Caso Tambien Se Puede Hacer Haciendo los Bucles anidados

            for (int i = 0; i < tamanyo; i++)
            {
                sw.WriteLine("{0};{1};{2};{3};{4};{5}",tablaIds[i], tApell[i], tNombre[i], tNotas[i,0],tNotas[i,1],tNotas[i,2]);
            }

            /*
            for (int i = 0; i < tamanyo; i++)
            {
                sw.Write("{0};{1};{2}", tablaIds[i], tApell[i], tNombre[i]);
                for (int j = 0; j < 3; j++)
                {
                    sw.Write(";{0}", tNotas[i, j]);
                }
            }
            */

            sw.Close();
            Console.WriteLine("Pulse Una Tecla Para Salir");
            Console.ReadKey(true);
        }

        private static float[,] Carga3Notas(int tamanyo)
        {
            float[,] tNotas = new float[tamanyo, 3];
            Random azar = new Random();
        //Podemos Crearlo de Dos Formas:
           /* for (int i = 0; i < tamanyo; i++)
            {
        //tNotas[i, 0] = (float)(azar.Next(100)* 0.1); Se puede hacer el Casting Así o Poniendo La F
                tNotas[i, 0] = azar.Next(100) * 0.1F;
                tNotas[i, 1] = azar.Next(100) * 0.1F;
                tNotas[i, 2] = azar.Next(100) * 0.1F;
            }*/
        //Se puede hacer en un bucle solo o haciendo bubles anidados
            for (int i = 0; i < tamanyo; i++)
            {
                for (int j = 0; j < 3; j++)
                    tNotas[i, j] = azar.Next(100) * 0.1F;
            }
            return tNotas;
        }


        private static byte[] CargaIds2Cifras(int tamanyo)
        {
            Random azar = new Random();
            byte[] tIds = new byte[tamanyo];
            List<byte> listAux = new List<byte>();
            for (byte i = 10; i < 100; i++)
             listAux.Add(i);

            int posAzar;
            for (int i = 0; i < tamanyo; i++)
            {
                posAzar = azar.Next(listAux.Count);
                tIds[i] = listAux[posAzar];
                listAux.RemoveAt(posAzar);
            }
            return tIds;
        }
    }
}
