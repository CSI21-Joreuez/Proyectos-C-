using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41b0_Paralelogramo
{
    class Rombo:Cuadrado
    {

        double angulo;

        public Rombo(string nombre, int ladobase, double angulo): base(nombre,ladobase)
        {

            this.angulo = angulo;
        }

        public int Perimetro {
            get { return Ladobase * 4; }
        }
        public double Area
        {
            get { double Area = Math.Round(Ladobase * Ladobase * Math.Sin(angulo * Math.PI / 180), 2); return Area; }
        }
        public string ComoString()
        {
            return string.Format("\t{0}{1}\t{2}\t{3}\t{4}\t{5}", Util.CuadraTexto(nombre, 8), Ladobase, Ladobase, angulo, Perimetro, Area);

        }
    }
}
