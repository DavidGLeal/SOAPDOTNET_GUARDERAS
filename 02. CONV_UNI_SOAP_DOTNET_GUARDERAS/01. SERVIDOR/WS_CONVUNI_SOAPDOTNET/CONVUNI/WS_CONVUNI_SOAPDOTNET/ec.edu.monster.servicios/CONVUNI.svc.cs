using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_CONVUNI_SOAPDOTNET.ec.edu.monster.controlador;

namespace WS_CONVUNI_SOAPDOTNET
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CONVUNI" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CONVUNI.svc o CONVUNI.svc.cs en el Explorador de soluciones e inicie la depuración.

    public class CONVUNI : ICONVUNI
    {
        private ConvuniControlador controlador;
        
        public CONVUNI()
        {
                controlador = new ConvuniControlador();
        }
        public double convertCF(double c)
        {
            return controlador.convCF(c);
        }

        public double convertFC(double f)
        {
            return controlador.convFC(f);
        }
    }
}
