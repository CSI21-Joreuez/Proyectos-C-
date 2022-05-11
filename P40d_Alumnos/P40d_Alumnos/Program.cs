using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40d_Alumnos
{
   
	class Alumno 
	{
		int numDNI;
		char letraDNI;
		string nombre, apellidos;
		byte anyo, mes, dia;
		float nota1, nota2, nota3;
		double Media;
        static Random azar = new Random();
        public Alumno(int numDNI, char letraDNI, string nombre, string apellidos, byte anyo, byte mes, byte dia, float nota1, float nota2, float nota3)
        {
            this.numDNI = numDNI;
            this.letraDNI = letraDNI;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.anyo = anyo;
            this.mes = mes;
            this.dia = dia;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }
        public double Media1 { get => Math.Round((float)azar.Next(3, 10),2); }

        public static void Mostrar()
        {
            Console.WriteLine("\t{0} {1} {2} {3}\t{4}  {5}  {6}  {7}");
        }
    }
}