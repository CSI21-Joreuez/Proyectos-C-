using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41a1AlumnosConHerencia
{
    class Fecha
    {
        int dia;
        int mes;
        int anyo;
        public int[] maxDiasMes = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31 };
        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Anyo { get => anyo; set => anyo = value; }

        public Fecha(int dia, int mes, int anyo)
        {
            this.dia = dia;
            this.mes = mes;
            this.anyo = anyo;
            if (EsBisiesto)
                maxDiasMes[2] = 29;
        }
        public Fecha()
        {
            anyo = DateTime.Now.Year;
            mes = DateTime.Now.Month;
            dia = DateTime.Now.Day;
        }
        public Fecha(int fecha)
        {
            anyo = fecha / 10000;
            mes = (fecha & 10000)/100;
            dia = (fecha & 1000000);
        }
        public int FechaEntero
        {
            get 
            {
                int dosCifrasAnyo = anyo % 100;
                return (dosCifrasAnyo * 1000 + mes * 100 + dia);
            }
        }
        public string FechaStringSp
        {
            get
            {
                return (dia.ToString("00") + "/" + mes.ToString("00") + "/" + anyo);
            }
        }
        public string FechaStringTexto
        {
            get
            {
                string[] vMeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
                return (dia + " De " + vMeses[mes] +" De " + anyo);
            }
        }

        public bool EsBisiesto
        {
            get
            {
                return ((anyo % 4 == 0 && anyo % 100 != 0) || anyo % 400 == 0);
            }
        }
        public void AvanzaDia()
        {
            dia++;
            if (dia > maxDiasMes[mes])
            {
                dia = 1;
                mes++;
            }
            if (mes > 12)
            {
                mes = 1;
                anyo++;
                if (EsBisiesto)
                    maxDiasMes[2] = 29;
                else
                    maxDiasMes[2] = 28;
            }
        } 
    }
}
