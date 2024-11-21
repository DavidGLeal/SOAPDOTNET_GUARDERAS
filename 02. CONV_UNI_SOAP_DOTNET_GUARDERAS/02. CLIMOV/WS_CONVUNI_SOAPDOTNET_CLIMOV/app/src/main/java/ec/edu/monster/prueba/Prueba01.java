package ec.edu.monster.ws_convuni_soapdotnet_climov.prueba;

import ec.edu.monster.ws_convuni_soapdotnet_climov.controlador.ConvUniControlador;

public class Prueba01 {
    public static void main(String[] args) {
        //Datos
        double c = 0;
        double f = 32;

        //Proceso
        ConvUniControlador servicio = new ConvUniControlador();
        String convF = servicio.convertCF(String.valueOf(c));
        String convC = servicio.convertFC(String.valueOf(f));

        //Reporte
        System.out.println(c + "°C = " + convF + "°F");
        System.out.println(f + "°F = " + convC + "°C");
    }
}
