using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41b0_Paralelogramo
{
    class Romboide
    {
        string nombre;
        int ladobase;
        int lado;
        double angulo;

        public Romboide(string nombre, int ladobase, int lado, double angulo)
        {
            this.nombre = nombre;
            this.ladobase = ladobase;
            this.lado = lado;
            this.angulo = angulo;
        }
        public int Perimetro
        {
            get { return (ladobase + ladobase) + (lado + lado); }
        }
        public double Area
        {
            get { double Area = Math.Round(ladobase * lado * Math.Sin(angulo * Math.PI / 180), 2); return Area; }
        }
        public string ComoString()
        {
            return string.Format("\t{0}{1}\t{2}\t{3}\t{4}\t{5}", Util.CuadraTexto(nombre, 8), ladobase, lado, angulo, Perimetro, Area);

        }
    }
}
