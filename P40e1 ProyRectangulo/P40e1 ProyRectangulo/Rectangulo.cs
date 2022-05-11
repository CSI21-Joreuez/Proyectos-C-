//Alumno: Orea,Juan Carlos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40e1_ProyRectangulo
{
    class Rectangulo
    {
        string nombre;
        int ladoBase;
        int ladoLateral;

        public Rectangulo(string nombre, int ladoBase, int ladoLateral)
        {
            this.nombre = nombre;
            this.ladoBase = ladoBase;
            this.ladoLateral = ladoLateral;
        }

        public int Perimetro {
            get { return 2 * ladoBase + 2 * ladoLateral; }
        }
        public int Area {
            get { return ladoBase * ladoLateral;}
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int LadoBase { get => ladoBase; set => ladoBase = value; }
        public int LadoLateral { get => ladoLateral; set => ladoLateral = value; }

        public  string RectanguloAString()
        {

            return string.Format("\t{0}\t{1}\t{2}\t{3}\t{4}", Util.CuadraTexto(nombre, 8), ladoBase, LadoLateral, Perimetro, Area);
        }
    }
}
