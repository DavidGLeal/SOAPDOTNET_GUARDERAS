using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIESC.ec.edu.monster.modelo;

namespace CLIESC.ec.edu.monster.controlador
{
    public class ConvUniControlador
    {
        private ConvUniModelo modelo;

        public ConvUniControlador()
        {
            modelo = new ConvUniModelo();
        }

        public object convertCF(double c)
        {
            return Convert.ToDouble(modelo.convertCF(c));
        }

        public object convertFC(double f)
        {
            return Convert.ToDouble(modelo.convertFC(f));
        }


    }
}
