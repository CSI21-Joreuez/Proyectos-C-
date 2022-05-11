using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40d_Alumnos
{
	class Util
	{
		public static DateTime FECHAHOY = DateTime.Now;
		public static string CuadraTexto(string texto, int numChar)
		{
			texto += "                                            ";
			return texto.Substring(0, numChar);
		}
	}
}
