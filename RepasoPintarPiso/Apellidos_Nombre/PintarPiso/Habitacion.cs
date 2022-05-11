using System;

namespace PintarPiso
{
	public class Habitacion : Recinto
	{
        public Habitacion(string nombre, double mPared, int numPuertas, int numVentanas, int tipoPintura) : base(nombre, mPared, numPuertas, numVentanas, tipoPintura)
        {
        }

        public Habitacion(string nombre, double mPared, int numPuertas, int numVentanas) : base(nombre, mPared, numPuertas, numVentanas)
        {
        }
        public override double SuperficiePintar
        {
            get { return MPared * 2.5 - NumPuertas * 1.6 - NumVentanas; }
        }
        public override double MuestraPrecioPintura()
        {
            Pintura p = CatalogoPinturas.listaPinturas[TipoPintura];
            double precio = Math.Round(SuperficiePintar * p.PrecioM2, 2);
            Console.WriteLine("   {0}{1}\t{2}\t{3}\t{4}\t{5}\t\t  {6}", Util.CuadraTexto(Nombre, 13), MPared, NumPuertas, NumVentanas, Util.CuadraTexto(p.NombreColor, 7), p.PrecioM2, precio);
            return precio;

        }
    }	
}
