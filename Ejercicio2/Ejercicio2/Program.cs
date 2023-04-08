using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*•	Escriba un programa que convierta de centímetros a pulgadas. Una pulgada es igual a 2.54 centímetros.

Ingrese longitud: 45
45 cm = 17.7165 in
Ingrese longitud: 13
13 cm = 5.1181 in
*/

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float longitudCentimetros;
            float longitudPulgadas;
            float pulgada = (float)2.54;

            longitudCentimetros = IngresoCentimetros();
            longitudPulgadas = ConversionPulgadas(longitudCentimetros, pulgada);
            MostrarPulgadas(longitudPulgadas);

            Console.WriteLine("Escriba cualquier caracter para salir");
            Console.ReadKey();
        }

        private static void MostrarPulgadas(float longitudPulgadas)
        {
            Console.WriteLine("El la conversion es: " + longitudPulgadas);
        }

        private static float ConversionPulgadas(float longitudCentimetros, float pulgada)
        {
            return longitudCentimetros / pulgada;
        }

        private static float IngresoCentimetros()
        {
            float longitudCentimetros;
            Console.WriteLine("Ingrese el la longitud en CM: ");
            longitudCentimetros = int.Parse(Console.ReadLine());
            return longitudCentimetros;
        }
    }
}
