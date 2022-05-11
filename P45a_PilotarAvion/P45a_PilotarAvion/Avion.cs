using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P45a_PilotarAvion
{
    public class Avion
    {
        string marca;
        string modelo;
        string matricula;
        const int ALTITUDMAXIMA = 9000;
        int altitud = 0;
        int velocidad = 0;

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Matricula { get => matricula; set => matricula = value; }

        public int Altitud { get => altitud; set => altitud = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }

        public Avion(string marca, string modelo, string matricula)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.matricula = matricula;
        }
        public static Avion AumentarVelocidad(int num)
        {
            Console.WriteLine("Has querido Aumentar {0} km/h",num);
            
        }
    }
}
