using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*9- Más corta y larga
Desarrolle un programa que tenga la siguiente entrada:
•	primero, el usuario ingresa un número entero n , que indica cuántas palabras ingresará a continuación;
•	después el usuario ingresa n palabras.
La salida del programa debe mostrar la palabra más larga y la más corta que fueron ingresadas por el usuario.
La ejecución del programa debe verse así:

Cantidad de palabras: 5
Palabra 1: negro
Palabra 2: amarillo
Palabra 3: naranjo
Palabra 4: azul
Palabra 5: blanco
La palabra más larga es amarillo
La palabra más corta es azul
*/


namespace Ejercicio9_Más_corta_y_larga
{
    class Program
    {
        static void Main(string[] args)
        {

            int cantidadDePalabras;

            cantidadDePalabras = SolicitarCantidadDePalabras();

            string[] palabras = new string[cantidadDePalabras];

            EspecificarPalabras(cantidadDePalabras, palabras);
            MostrarPalabras(cantidadDePalabras, palabras);

            string masLarga, masCorta;

            CompararPalabras(cantidadDePalabras, palabras, out masLarga, out masCorta);
            MostrarMasLargaYCorta(masLarga, masCorta);

            Console.ReadKey();
        }

        private static void MostrarPalabras(int cantidadDePalabras, string[] palabras)
        {
            for (int i = 0; i < cantidadDePalabras; i++)
            {
                Console.WriteLine("\nla palabra" + (i + 1) + ": {0} ", palabras[i]);
            }
        }

        private static void EspecificarPalabras(int cantidadDePalabras, string[] palabras)
        {
            for (int i = 0; i < cantidadDePalabras; i++)
            {
                Console.WriteLine("Ingrese la palabra {0}: ", i + 1);
                palabras[i] = Console.ReadLine();
            }

            Console.WriteLine("Cantidad de palabras: {0}", cantidadDePalabras);
        }

        private static int SolicitarCantidadDePalabras()
        {
            int cantidadDePalabras;
            Console.WriteLine("Ingrese la cantidad de palabras que desee ingresar: ");
            cantidadDePalabras = int.Parse(Console.ReadLine());
            return cantidadDePalabras;
        }

        private static void MostrarMasLargaYCorta(string masLarga, string masCorta)
        {
            Console.WriteLine($"\nLa palabra más larga es {masLarga}");
            Console.WriteLine($"La palabra más corta es {masCorta}");
        }

        private static void CompararPalabras(int cantidadDePalabras, string[] palabras, out string masLarga, out string masCorta)
        {
            masLarga = palabras[0];
            masCorta = palabras[0];
            for (int i = 1; i < cantidadDePalabras; i++)
            {
                if (palabras[i].Length > masLarga.Length)
                {
                    masLarga = palabras[i];
                }

                if (palabras[i].Length < masCorta.Length)
                {
                    masCorta = palabras[i];
                }
            }
        }
    }
}
