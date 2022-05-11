using System;

namespace PintarPiso
{
	public class Pintura
	{
		string nombreColor;
		double precioM2;

        public Pintura(string nombreColor, double precioM2)
        {
            this.nombreColor = nombreColor;
            this.precioM2 = precioM2;
        }

        public string NombreColor { get => nombreColor; set => nombreColor = value; }
        public double PrecioM2 { get => precioM2; set => precioM2 = value; }
    }
}
