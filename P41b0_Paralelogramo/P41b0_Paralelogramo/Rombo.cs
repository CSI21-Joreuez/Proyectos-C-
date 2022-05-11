using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41b0_Paralelogramo
{
    class Rombo
    {
        string nombre;
        int ladobase;
        double angulo;

        public Rombo(string nombre, int ladobase, double angulo)
        {
            this.nombre = nombre;
            this.ladobase = ladobase;
            this.angulo = angulo;
        }

        public int Perimetro {
            get { return ladobase * 4; }
        }
        public double Area
        {
            get { double Area = Math.Round(ladobase * ladobase * Math.Sin(angulo * Math.PI / 180), 2); return Area; }
        }
        public string ComoString()
        {
            return string.Format("\t{0}{1}\t{2}\t{3}\t{4}\t{5}", Util.CuadraTexto(nombre, 8), ladobase, ladobase, angulo, Perimetro, Area);

        }
    }
}
