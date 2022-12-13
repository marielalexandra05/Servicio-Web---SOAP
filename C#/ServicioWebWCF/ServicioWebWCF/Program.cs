using ServicioWebWCF.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioWebWCF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola");     
            Servicio.WSOperacionesClient servicioC = new WSOperacionesClient();

            if (servicioC.login("mariela", "leon2000"))
            {
                Console.WriteLine("Credenciales correctas");
            }
            else
            {
                Console.WriteLine("Credenciales Incorrectas");
            }

            if (servicioC.ProcesarPago(250, 400) != -1)
            {
                Console.WriteLine("Pago realizado con exito");
                Console.WriteLine("Su vuelto es " + servicioC.ProcesarPago(250, 400));
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");

            }

        }
    }
}
