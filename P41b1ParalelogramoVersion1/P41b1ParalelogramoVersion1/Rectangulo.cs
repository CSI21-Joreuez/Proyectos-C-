using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41b0_Paralelogramo
{
    class Rectangulo:Cuadrado
    {

        int lado;


        public  Rectangulo(string nombre, int lado, int ladobase):base(nombre, ladobase)
        {

            this.lado = lado;

        }
        public override int Perimetro
        {
            get { return (LadoBase  + Ladobase) +(lado +lado) ; }
        }
        public override double Area
        {
            get { return Ladobase*lado; }
        }
        public override string ComoString()
        {
            return string.Format("\t{0}{1}\t{2}\t{3}\t{4}\t{5}", Util.CuadraTexto(Nombre, 8), Ladobase, lado, 90, Perimetro, Area);

        }
    }
}
