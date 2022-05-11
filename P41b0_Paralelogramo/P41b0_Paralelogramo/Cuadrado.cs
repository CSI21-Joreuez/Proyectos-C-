using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41b0_Paralelogramo
{
    class Cuadrado
    {
        string nombre;
        int ladobase;

        public Cuadrado(string nombre, int ladobase)
        {
            this.nombre = nombre;
            this.ladobase = ladobase;
        }
        public int Perimetro
        {
            get { return ladobase * 4; }
        }
        public double Area
        {
            get {  return ladobase*ladobase; }
        }
        public string ComoString()
        {
            return string.Format("\t{0}{1}\t{2}\t{3}\t{4}\t{5}", Util.CuadraTexto(nombre, 8), ladobase, ladobase, 90, Perimetro, Area);

        }
    }
}
