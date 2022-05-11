using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41b0_Paralelogramo
{
    class Rectangulo
    {
        string nombre;
        int lado;
        int ladobase;

        public Rectangulo(string nombre, int lado, int ladobase)
        {
            this.nombre = nombre;
            this.lado = lado;
            this.ladobase = ladobase;
        }
        public int Perimetro
        {
            get { return (ladobase + ladobase) +(lado +lado) ; }
        }
        public double Area
        {
            get { return ladobase*lado; }
        }
        public string ComoString()
        {
            return string.Format("\t{0}{1}\t{2}\t{3}\t{4}\t{5}", Util.CuadraTexto(nombre, 8), ladobase, lado, 90, Perimetro, Area);

        }
    }
}
