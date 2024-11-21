using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CONVUNI;

namespace CLICON.ec.edu.monster.modelo
{
    public class ConvUniModelo
    {
        private CONVUNIClient servicio;
        
        public ConvUniModelo()
        {
            servicio = new CONVUNIClient(new CONVUNIClient.EndpointConfiguration());
        }

        public Object convertCF(double c)
        {
            try
            {
                return servicio.convertCFAsync(c).Result;
            }catch(Exception e)
            {
                Console.WriteLine("Error. El servicio web no está disponible.");
                return null;
            }
        }

        public Object convertFC(double f)
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
