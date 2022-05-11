//Alumno: Orea, Juan Carlos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41b4_Paralelogramo
{
    class Rombo : Paralelogramo
    {
        public Rombo(string nombre, int ladobase, double angulo): base(nombre,ladobase,ladobase,angulo)
        {
        }

        public override int Perimetro {
            get { return ladobase * 4; }
        }
        public override double Area
        {
            get { double Area = Math.Round(ladobase * ladobase * Math.Sin(angulo * Math.PI / 180), 2); return Area; }
        }
    }
}
