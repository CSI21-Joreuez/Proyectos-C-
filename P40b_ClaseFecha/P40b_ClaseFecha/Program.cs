using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40b_ClaseFecha
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Fecha
    {
        public int fechaEntero
        { get 
                
                }
        int anyo, mes, dia;

        public Fecha(int anyo, int mes, int dia)
        {
            this.anyo = anyo;
            this.mes = mes;
            this.dia = dia;
        }
        public Fecha()
        {
            DateTime fechaHoy = DateTime.Now;
        }
       
    }
}
