//Alumno: Orea, Juan Carlos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41b4_Paralelogramo
{
    class Romboide : Paralelogramo
    {
        public Romboide(string nombre, int ladobase, int lado, double angulo) : base(nombre, ladobase, lado, angulo)
        {
        }
        public override double Area 
        {
            get { double Area = Math.Round(ladobase * lado * Math.Sin(angulo * Math.PI / 180), 2); return Area; }

        }
        public override int Perimetro 
        {
            get { int Perimetro = (ladobase + ladobase) + (lado + lado); return Perimetro; } 
        }
    }
}
