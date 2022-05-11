using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PintarPiso
{
    public abstract class Recinto
    {
        string nombre;  // Nombre de la habitación
        double mPared;  // metros de pared de la habitación
        int numPuertas; // Número de puertas de 2 x 0.80 m2
        int numVentanas;// Número de ventanas de 1x1 m2
        int tipoPintura;// id del tipo de pintura en el catálogo [0..4]

        public string Nombre { get => nombre; set => nombre = value; }
        public double MPared { get => mPared; set => mPared = value; }
        public int NumPuertas { get => numPuertas; set => numPuertas = value; }
        public int NumVentanas { get => numVentanas; set => numVentanas = value; }
        public int TipoPintura { get => tipoPintura; set => tipoPintura = value; }
        public abstract double SuperficiePintar { get; }

        public Recinto(string nombre, double mPared, int numPuertas, int numVentanas, int tipoPintura)
        {
            this.nombre = nombre;
            this.mPared = mPared;
            this.numPuertas = numPuertas;
            this.numVentanas = numVentanas;
            this.tipoPintura = tipoPintura;
        }
        public Recinto(string nombre, double mPared, int numPuertas, int numVentanas)
        {
            this.nombre = nombre;
            this.mPared = mPared;
            this.numPuertas = numPuertas;
            this.numVentanas = numVentanas;
            this.tipoPintura = 0;
        }
        public abstract double MuestraPrecioPintura();
    }
}
