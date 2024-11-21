using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceReference1;

namespace CLIESC.ec.edu.monster.modelo
{
    public class ConvUniModelo
    {
        private CONVUNIClient servicio;

        public ConvUniModelo()
        {
            servicio = new CONVUNIClient(new CONVUNIClient.EndpointConfiguration());
        }

        public object convertCF(double c)
        {
            try
            {
                return servicio.convertCFAsync(c).Result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error. El servicio web no está disponible.");
                return null;
            }
        }

        public object convertFC(double f)
        {
            try
            {

                return servicio.convertFCAsync(f).Result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error. El servicio web no está disponible.");
                return null;
            }
        }
    }
}
