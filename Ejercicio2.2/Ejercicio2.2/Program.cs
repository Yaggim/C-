using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*•	Escriba un programa similar al anterior pero que convierta de pesos a dólares recibiendo la cotización a aplicar.

Ingrese valor en pesos: 100
Ingrese cotización del U$S: 96,50
$100 ARS = U$S 1,03
 
*/


namespace Ejercicio2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            int pesos;
            float cotizacion = (float)96.50;
            float conversionDolares; 


            pesos = IngresoEnPesos();
            conversionDolares = ConversionADolares(pesos, cotizacion);
            MostrarPorConsola(conversionDolares);

            Console.WriteLine("Resiones una tecla para continuar...");
            Console.ReadKey();


        }

        private static void MostrarPorConsola(float conversionDolares)
        {
            Console.WriteLine("La conversion en dolares es: " + conversionDolares + " USD");
        }

        private static float ConversionADolares(int pesos, float cotizacion)
        {
            return pesos / cotizacion;
        }

        private static int IngresoEnPesos()
        {
            int pesos;
            Console.WriteLine("Ingrese el valor en pesos: ");
            pesos = int.Parse(Console.ReadLine());
            return pesos;
        }
    }
}
