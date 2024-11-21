using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_CONVUNI_SOAPDOTNET
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICONVUNI" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICONVUNI
    {
        [OperationContract]
        double convertCF(double c);

        [OperationContract]
        double convertFC(double f);
    }
}
