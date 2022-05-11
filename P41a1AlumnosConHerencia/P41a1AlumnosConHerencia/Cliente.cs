using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41a1AlumnosConHerencia
{
    class Cliente
    {
        int numDNI;
        Char letraDNI;
        String nombre;
        string apellidos;
        Fecha fechaNac;
        public Cliente(int numDNI, char letraDNI, string nombre, string apellidos, Fecha fechaNac)
        {
            this.numDNI = numDNI;
            this.letraDNI = letraDNI;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
        }
        public int Edad
        {
        get
            {
               int anyoHoy = DateTime.Now.Year;
                int mesHoy = DateTime.Now.Month;
                int diaHoy = DateTime.Now.Day;
                int edad = anyoHoy - fechaNac.Anyo;
                if ((mesHoy < fechaNac.Mes) || mesHoy == fechaNac.Mes && diaHoy == fechaNac.Dia)
                    edad--;
                return edad;
                
            }
        
        }
    }
}
