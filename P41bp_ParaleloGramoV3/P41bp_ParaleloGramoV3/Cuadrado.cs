//Alumno: Orea, Juan Carlos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41b0_Paralelogramo
{
    class Cuadrado:Romboide
    {

        public Cuadrado(string nombre, int ladobase):
            base(nombre,ladobase,ladobase,90)
        {
        }
        public override int Perimetro
        {
            get { return ladobase * 4; }
        }
        public override double Area
        {
            get {  return ladobase*ladobase; }
        }
    }
}
