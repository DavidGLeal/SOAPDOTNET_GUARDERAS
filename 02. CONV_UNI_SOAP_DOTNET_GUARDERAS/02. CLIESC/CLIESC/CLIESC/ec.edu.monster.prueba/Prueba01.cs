using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIESC.ec.edu.monster.controlador;

namespace CLIESC.ec.edu.monster.prueba
{
    public class Prueba01
    {

        public static void Main(string[] args)
        {
            double c = 0;
            double f = 32;

            ConvUniControlador controlador = new ConvUniControlador();
            object nuevF = controlador.convertCF(c);
            object nuevC = controlador.convertFC(f);

            Console.WriteLine(c + "°C = " + nuevF + "°F");
            Console.WriteLine(f + "°F = " + nuevC + "°C");
        }
    }
}
