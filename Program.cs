using System;

namespace Primer_Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            string datos = "";
            int edad = 0;
            double altura = 0.0;

            Console.WriteLine("¡Bienvenido al Parque Infantil Yuppie!:");
            Console.WriteLine("Ingrese su edad:");
            datos = Console.ReadLine();
            edad = Convert.ToInt32(datos);

            if (edad <= 13)
            {
                Console.WriteLine("Cumples con los requisitos para entrar, ¡Disfrute su estadia!:");

                Console.WriteLine("Ingrese su altura:");
                datos = Console.ReadLine();
                altura = Convert.ToDouble(datos);

                if (altura < 1.5)
                {
                    Console.WriteLine("Segun tu altura puedes ingresar a la mayoria de atracciones, exceptuando la montaña rusa y demas atracciones con limites de altura");
                }
                else
                {
                    Console.WriteLine("Segun tu altura puedes ingresar a la todas las atracciones, incluyendo la montaña rusa ");
                }

            }
            else
            {
                Console.WriteLine("Lamentablemente superas el limite de edad para entrar, disculpe las molestias:");
            }
            /*Irvin Sánchez
            C.I.: 28232012
            Carrera: Ing. en Información
            */
            
        }
    }
}
