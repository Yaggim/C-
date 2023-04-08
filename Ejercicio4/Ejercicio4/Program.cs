using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*4- Palabra más larga
Escriba un programa que pida al usuario dos palabras, y que indique cuál de ellas es la más larga y por cuántas letras lo es.
*/

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra1, palabra2;

            IngresoDePalabras(out palabra1, out palabra2);
            CompararPalabras(palabra1, palabra2);

            Console.ReadKey();
        }

        private static void CompararPalabras(string palabra1, string palabra2)
        {
            if (palabra1.Length > palabra2.Length)
            {
                Console.WriteLine("{0} es más larga que {1} por {2} letras.", palabra1, palabra2, palabra1.Length - palabra2.Length);
            }
            else if (palabra2.Length > palabra1.Length)
            {
                Console.WriteLine("{0} es más larga que {1} por {2} letras.", palabra2, palabra1, palabra2.Length - palabra1.Length);
            }
            else
            {
                Console.WriteLine("Las dos palabras tienen la misma longitud.");
            }
        }

        private static void IngresoDePalabras(out string palabra1, out string palabra2)
        {
            Console.Write("Ingrese la primera palabra: ");
            palabra1 = Console.ReadLine();
            Console.Write("Ingrese la segunda palabra: ");
            palabra2 = Console.ReadLine();
        }
    }
}

