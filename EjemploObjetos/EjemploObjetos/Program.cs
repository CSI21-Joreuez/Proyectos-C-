using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Juan Carlos", "Orea Rodriguez", 24, 09, 2002);
            Persona p2 = new Persona("Juan Carlos", "Orea Rodriguez");
            p.Mostrar();
            p2.Mostrar();
            Console.WriteLine("-----------------------");
            Persona[] vPersonas = { p, p2 };
            foreach (Persona pe in vPersonas)
            {
                p.Mostrar();
            }
            Console.WriteLine("------------------------");
            for (int i = 0; i < vPersonas.Length; i++)
            {
                vPersonas[i].Mostrar();
            }
            Console.WriteLine("Introduzca una letra para salir");
            Console.ReadKey(true);
        }
    }
    public class Persona
    {
        string nombre;
        string apellidos;
        int dia, mes, anyo; //Fecha de Nacimiento

        public Persona(string nombre, string apellidos, int dia, int mes, int anyo)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dia = dia;
            this.mes = mes;
            this.anyo = anyo;
        }
        public Persona(string nombre, string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            dia = 1;
            mes = 1;
            anyo = 1500;
        }
        public Persona()
        {
        }

        public void Mostrar()
        {
            Console.WriteLine("{0},{1} nacido en {2}/{3}/{4}", apellidos, nombre, dia,mes,anyo);
        }
    }

}
