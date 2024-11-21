using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS_CONVUNI_SOAPDOTNET.ec.edu.monster.modelo;

namespace WS_CONVUNI_SOAPDOTNET.ec.edu.monster.controlador
{
    public class ConvuniControlador
    {
        private ConvuniModelo modelo;

        public ConvuniControlador()
        {
            modelo = new ConvuniModelo();
        }

        public double convCF(double c)
        {
            return modelo.convertCF(c);
        }

        public double convFC(double f)
        {
            return modelo.convertFC(f);
        }
    }
}