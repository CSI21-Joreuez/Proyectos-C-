
using System;

namespace PintarPiso
{
    class Terraza : Recinto
    {
        double mPretil;   // metros lineales de pretil

        public Terraza(string nombre, double mPared, int numPuertas, int numVentanas, int tipoPintura, double mPretil) : base(nombre, mPared, numPuertas, numVentanas, tipoPintura)
        {
            this.mPretil = mPretil;
        }

        public double MPretil { get => mPretil; }
        public override double SuperficiePintar { get { return MPared * 2.5 - NumPuertas * 1.6 - NumVentanas + mPretil * 1.5; } }

        public override double MuestraPrecioPintura()
        {
            Pintura p = CatalogoPinturas.listaPinturas[TipoPintura];
            double precio = Math.Round(SuperficiePintar * p.PrecioM2 ,2);
            Console.WriteLine("   {0}{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t  {7}", Util.CuadraTexto(Nombre, 13), MPared,NumPuertas,NumVentanas,Util.CuadraTexto(p.NombreColor,7),p.PrecioM2,mPretil,precio);
            return precio;

        }
    }
}
