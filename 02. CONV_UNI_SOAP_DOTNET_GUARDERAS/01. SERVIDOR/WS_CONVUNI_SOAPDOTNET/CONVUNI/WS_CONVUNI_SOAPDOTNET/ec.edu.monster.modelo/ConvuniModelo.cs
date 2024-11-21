using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_CONVUNI_SOAPDOTNET.ec.edu.monster.modelo
{
    public class ConvuniModelo
    {
        public double convertCF(double c)
        {
            return (c * 9 / 5) + 32;
        }

        public double convertFC(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }
}