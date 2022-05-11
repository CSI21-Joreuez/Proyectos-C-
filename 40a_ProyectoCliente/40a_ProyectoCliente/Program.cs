using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _40a_ProyectoCliente
{            
    
    class Program
    {
        static void Main(string[] args)
        {
            List <Cliente> listaClientes = new List<Cliente>();
            StreamReader sr = File.OpenText(@"./Clientes.TXT");
            string[] registro;
            
            while (!sr.EndOfStream)
            {
                registro = sr.ReadLine().Split('/');
             //   Cliente c = new Cliente(Convert.ToInt32(registro[0]), Convert.ToInt32(registro[1]), registro[2], registro[3], Convert.ToInt32(registro[4]), Convert.ToInt32(registro[5])); 
                
            }
                
            foreach(Cliente r in listaClientes)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine("Pulsa Una tecla para salir");
            Console.ReadKey();
        }
    }
    public class Cliente
    {
        int numDNI;
        char letraDNI;
        string nombre, apellidos;
        byte anyo, mes, dia; //Fecha de Nacimiento

        public Cliente(int numDNI, char letraDNI, string nombre, string apellidos, byte anyo, byte mes, byte dia)
        {
            this.numDNI = numDNI;
            this.letraDNI = letraDNI;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.anyo = anyo;
            this.mes = mes;
            this.dia = dia;

            if (anyo > FECHAHOY.Year * 100)
                anyo4cifras = 1900 + anyo;
            else
                anyo4ciffras = 2000 + anyo;

        }
        public static DateTime FECHAHOY = DateTime.Now();

        void Mostrar()
        {
            string nombreP = nombre + " " + apellidos;
            Console.WriteLine("\t{0}-{1}   {2}     {3}/{4}/{5}",numDNI,letraDNI,nombreP, dia,mes,anyo);

        }
        int Edads(byte anyo, byte mes, byte dia)
        {
            int anyoHoy = FECHAHOY.Year;
            int mesHoy = FECHAHOY.Month;
            int DiaHoy = FECHAHOY.Day;

            int edad = anyoHoy = anyo4cifras;
            if ((mesHoy < mes) || (mesHoy == mes && diaHoy < dia))
                edad--;

            return (byte)edad;
        }
        public byte Edad(byte anyo, byte mes, byte dia)
        {
            int anyoHoy = 2022;
            int mesHoy = 2;
            int diaHoy = 16;
            //CON BYTE
            int anyo4cifras = anyo;
            if (anyo > 22)
                anyo4cifras = 1900 + anyo;
            else
                anyo4cifras = 2000 + anyo;

            //TEORICAMENTE
            int edad = anyoHoy - anyo;
            if ((mesHoy < mes) || (mesHoy == mes && diaHoy < dia))
                edad--;
            //Con numeros +DIFICULTAD
            int fechaHoy = 100 * mesHoy + diaHoy;
            int fechaCumple = 100 * mes + dia;
            if (fechaHoy < fechaCumple)
                edad--;


            return (byte)edad;
        }
        static string CuadraTexto(string texto, int numChar)
        {
        texto = texto
        
        }
    }
}
