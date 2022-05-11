//Alumno: Orea, Juan Carlos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41b0_Paralelogramo
{
    class Rectangulo:Romboide
    {
        public  Rectangulo(string nombre, int lado, int ladobase):
            base(nombre,ladobase,lado,90)
        {
        }
        public override double Area
        {
            get { return ladobase*lado; }
        }

    }
}
