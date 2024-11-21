using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLICON.ec.edu.monster.modelo;

namespace CLICON.ec.edu.monster.controlador
{
    public class ConvUniControlador
    {
        private ConvUniModelo modelo;
        
        public ConvUniControlador()
        {
            modelo = new ConvUniModelo();
        }

        public Object convertCF(double c)
        {
            return Convert.ToDouble(modelo.convertCF(c));
        }

        public Object convertFC(double f)
        {
            return Convert.ToDouble(modelo.convertFC(f));
        }


    }
}
