using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p34a_EscribirRegistros
{
    class Program
    {
        static string[] tApell = { "Sánchez Elegante", "Arenas Mata", "García Solís", "Rodríguez Vázquez", "Hurtado Miranda", "Pinto Mirinda", "Barrios Garrobo", "Márquez Salazar", "Medina Gómez", "Alonso Pérez", "López Mora", "González Chaparro", "Ferrer Jiménez", "Morales Moncayo", "Fernández Perea", "Blanco Roldán", "Navarro Romero", "Aguilar Rubio", "Baena Fernández", "Barco Ramírez", "Delgado Rodríguez", "Duque Martínez" };
        static string[] tNomb = { "Álvaro", "Daniel Luis", "Juan Manuel", "Agustin", "Fco. Javier", "José Manuel", "Tomás", "Carlos", "Jose Carlos", "Juan Luis", "Daniel", "Angel", "Jacobo", "Alejandro", "Francisco", "Alfredo", "Francisco", "Antonio", "Constantino", "Roberto", "Rafael", "Antonio" };
        static void Main(string[] args)
        {
            int tamanyo = tNomb.Length;
            byte[] tIds = new byte [tamanyo];
            Random azar = new Random();
            int aleatorio;
            int aux=0;
            for (int i = 0; i < tamanyo; i++)
            {
                aleatorio = azar.Next(100, 1000);
                tIds[i] = (byte)aleatorio;
                Console.WriteLine(tIds[i]);
            }
            //Hola Mundo
            Console.WriteLine("-------------------");
            float[,] tNotas = new float[tIds.Length,tamanyo];
            for (int i = 0; i < tNotas.GetLength(0); i++)
            {
                for (int a = 0; a < tamanyo; a++)
                {
                    aleatorio = azar.Next(0, 10);
                    tNotas[i, a]= aleatorio;
                    
                }
            }


            Console.ReadKey();
        }
    }
}
