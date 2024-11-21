using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS_CONVUNI_SOAPDOTNET.ec.edu.monster.controlador;

namespace WS_CONVUNI_SOAPDOTNET.ec.edu.monster.prueba
{
    public class Prueba01
    {

        public static void Main(string[] args)
        {
            double c = 0;
            double f = 32;

            ConvuniControlador controlador = new ConvuniControlador();
            object nuevF = controlador.convCF(c);
            object nuevC = controlador.convFC(f);

            Console.WriteLine(c + "°C = " + nuevF + "°F");
            Console.WriteLine(f + "°F = " + nuevC + "°C");
        }
    }
}
