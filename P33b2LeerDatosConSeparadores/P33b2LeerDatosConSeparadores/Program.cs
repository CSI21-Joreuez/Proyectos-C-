using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P33b2LeerDatosConSeparadores
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = File.OpenText(@".\Datos\AlumNotas.txt");
            String registro;
            String[] vCampos;
            while (!sr.EndOfStream)
            {
                registro = sr.ReadLine();
                vCampos = registro.Split(';');
                Console.WriteLine("     {0} {1} {2}\t{3}\t{4}\t{5}",vCampos[0], CuadraTexto(vCampos[1],30, ' '),
                    vCampos[2], vCampos[3], vCampos[4], Math.Round((Convert.ToSingle(vCampos[2]) +
                    Convert.ToSingle(vCampos[3]) + Convert.ToSingle(vCampos[1]) /3 ) ));                                                                                                                                                                                                                                                                                                                                                
            }
            sr.Close();
            
            Console.ReadKey();
        }
        static String CuadraTexto(string texto, int numChar, char carac)
        {
            
            if (texto.Length > numChar)
                return texto.Substring(0, numChar);
            for (int i = 0; i < numChar; i++)
            {
                while(texto.Length<numChar)
                texto += carac;
            }
            return texto;
        }
    }
}
