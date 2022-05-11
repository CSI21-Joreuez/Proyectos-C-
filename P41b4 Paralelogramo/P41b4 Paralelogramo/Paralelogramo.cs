//Alumno: Orea, Juan Carlos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41b4_Paralelogramo
{
    public abstract class Paralelogramo
    {
        protected string nombre;
        protected int ladobase;
        protected int lado;
        protected double angulo;

        public Paralelogramo(string nombre, int ladobase, int lado, double angulo)
        {
            this.nombre = nombre;
            this.ladobase = ladobase;
            this.lado = lado;
            this.angulo = angulo;
        }
        public virtual int Perimetro
           { get => Perimetro; set => Perimetro = value; }

        public virtual double Area
        { get => Area; set => Area = value; }



        public override string ToString()
        {
            return string.Format("\t{0}{1}\t{2}\t{3}\t{4}\t{5}", Util.CuadraTexto(nombre, 8), ladobase, lado, angulo, Perimetro, Area);

        }
    }
}
