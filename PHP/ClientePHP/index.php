
<?php

//Creacion de cliente
$cliente = new SoapClient('http://localhost:8080/ServicioWeb_SOAP/WSOperaciones?WSDL');

//Método de pago
$resultado_pago = $cliente->ProcesarPago([
            "total" => 1000,
            "pago" => 5000
        ])->return;


if ($resultado_pago >= 0) {
    echo 'Pago realizado con exito';
} else {
    echo 'Saldo Insuficiente';
}
?>