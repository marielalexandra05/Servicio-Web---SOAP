/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Test;

import ws.WSOperaciones;
import ws.WSOperaciones_Service;

/**
 *
 * @author Lenovo
 */
public class TestWS {

    public static void main(String[] args) {
        // crear el cliente
        WSOperaciones_Service servicio = new WSOperaciones_Service();
        WSOperaciones cliente = servicio.getWSOperacionesPort();

        // utilizar metodos 
        //.- login
        if (cliente.login("mariela", "leon2000")) {
            System.out.println("Credenciales correctas");
        } else {
            System.out.println("Credenciales Incorrectas");
        }
        //2.- procesar pago 
        if (cliente.procesarPago(250, 400) != -1) {
            System.out.println("Pago realizado con exito");
            System.out.println("Su vuelto es " + cliente.procesarPago(250, 400));
        } else {
            System.out.println("Saldo Insuficiente");

        }
    }
}
