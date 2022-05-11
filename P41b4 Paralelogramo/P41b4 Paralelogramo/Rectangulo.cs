//Alumno: Orea, Juan Carlos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41b4_Paralelogramo
{
    class Rectangulo : Paralelogramo
    {
        public  Rectangulo(string nombre, int lado, int ladobase):
            base(nombre,ladobase,lado,90)
        {
        }
        public override int Perimetro 
        {
            get { int Perimetro = (ladobase + ladobase) + (lado + lado); return Perimetro; }
        }
        public override double Area
        {
            get { return ladobase*lado; }
        }

    }
}
