package ec.edu.monster.ws_convuni_soapdotnet_climov.modelo;

import android.util.Log;

import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapPrimitive;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

public class ConvUniModelo {
    private static final String NAMESPACE = "http://tempuri.org/";
    private static final String METHOD_NAME1 = "convertCF", METHOD_NAME2 = "convertFC";
    private static final String SOAP_ACTION1 = "http://tempuri.org/ICONVUNI/convertCF",
            SOAP_ACTION2 = "http://tempuri.org/ICONVUNI/convertFC";
    private static final String URL = "http://192.168.100.22/CONVUNI/ec.edu.monster.servicios/CONVUNI.svc";

    public double convertCF(double c){
        double respuesta = -1;

        try{
            SoapObject solicitud = new SoapObject(NAMESPACE,METHOD_NAME1);
            solicitud.addProperty("c",String.valueOf(c));

            SoapSerializationEnvelope paquete = new SoapSerializationEnvelope(SoapEnvelope.VER11);
            paquete.implicitTypes = true;
            paquete.dotNet = true;
            paquete.encodingStyle = SoapSerializationEnvelope.XSD;
            paquete.setOutputSoapObject(solicitud);

            HttpTransportSE transporte = new HttpTransportSE(URL);
            transporte.debug = true;

            Log.d("SOAP_REQUEST", solicitud.toString());
            transporte.call(SOAP_ACTION1, paquete);
            Log.d("SOAP_RESPONSE", paquete.getResponse().toString());


            SoapPrimitive res = (SoapPrimitive) paquete.getResponse();
            respuesta = Double.parseDouble(res.toString());
        }catch (Exception e){
            e.printStackTrace();
        }
        return respuesta;
    }

    public double convertFC(double f){
        double respuesta = -1;

        try{
            SoapObject solicitud = new SoapObject(NAMESPACE,METHOD_NAME2);
            solicitud.addProperty("f",String.valueOf(f));

            SoapSerializationEnvelope paquete = new SoapSerializationEnvelope(SoapEnvelope.VER11);
            paquete.implicitTypes = true;
            paquete.dotNet = true;
            paquete.encodingStyle = SoapSerializationEnvelope.XSD;
            paquete.setOutputSoapObject(solicitud);

            HttpTransportSE transporte = new HttpTransportSE(URL);
            Log.d("SOAP_REQUEST", solicitud.toString());
            transporte.call(SOAP_ACTION2, paquete);
            Log.d("SOAP_RESPONSE", paquete.getResponse().toString());

            SoapPrimitive res = (SoapPrimitive) paquete.getResponse();
            respuesta = Double.parseDouble(res.toString());
        }catch (Exception e){
            e.printStackTrace();
        }
        return respuesta;
    }
}
