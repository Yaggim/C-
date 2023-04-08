using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*11- Dígitos
Escriba un programa que determine la cantidad de dígitos en un número entero ingresado por el usuario:
Ingrese número: 2048
2048 tiene 4 dígitos
Ingrese número: 12
12 tiene 2 dígitos
Ingrese número: 0
0 tiene 1 dígito
*/

namespace Ejercicio11_Digitos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int cantidadDeDigitos;

            numero = SolicitudDeNumero();
            cantidadDeDigitos = ContarNumeros(numero);
            MostrarNumeros(numero, cantidadDeDigitos);

            Console.ReadKey();
        }

        private static void MostrarNumeros(int numero, int cantidadDeDigitos)
        {
            Console.WriteLine("El numero {0} tiene {1} digitos", numero, cantidadDeDigitos);
        }

        private static int ContarNumeros(int numero)
        {
            return numero.ToString().Length;
        }

        private static int SolicitudDeNumero()
        {
            int numero;
            Console.WriteLine("Ingrese un numero entero:");
            numero = int.Parse(Console.ReadLine());
            return numero;
        }
    }
}
