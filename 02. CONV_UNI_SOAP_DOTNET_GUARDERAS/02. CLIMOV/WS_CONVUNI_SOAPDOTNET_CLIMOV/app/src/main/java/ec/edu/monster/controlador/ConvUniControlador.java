package ec.edu.monster.ws_convuni_soapdotnet_climov.controlador;

import ec.edu.monster.ws_convuni_soapdotnet_climov.modelo.ConvUniModelo;

public class ConvUniControlador {

    private ConvUniModelo modelo;

    public ConvUniControlador(){
        modelo = new ConvUniModelo();
    }

    public String convertCF(String c){
        double envio = Double.valueOf(c);

        double recibo = modelo.convertCF(envio);

        String respuesta = "";

        if(recibo == -1.0){
            respuesta = "error";
        }else{
            respuesta = Double.toString(recibo);
        }

        return respuesta;
    }

    public String convertFC(String f){
        double envio = Double.valueOf(f);

        double recibo= modelo.convertFC(envio);

        String respuesta = "";

        if(recibo == -1.0){
            respuesta = "error";
        }else{
            respuesta = Double.toString(recibo);
        }

        return respuesta;
    }

}
