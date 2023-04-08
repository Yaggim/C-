using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Escriba un programa que pida al usuario dos números enteros, y luego entregue la suma de
todos los números que están entre ellos. Por ejemplo, si los números son 1 y 7, debe
entregar como resultado 2 + 3 + 4 + 5 + 6 = 20.

Ingresse num: 1
Ingrese num: 7
La suma es 20
*/


namespace Ejercicio7_Suma_entre_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado = 0;

            SolicitarNumeros(out numero1, out numero2);
            resultado = Resolución(numero1, numero2, resultado);
            ImprimirPorPantalla(resultado);
        }

        private static void ImprimirPorPantalla(int resultado)
        {
            Console.WriteLine("El resultado es: " + resultado);

            Console.ReadKey();
        }

        private static int Resolución(int numero1, int numero2, int resultado)
        {
            if (numero1 >= numero2)
            {

                for (int i = numero2; i < numero1 - 1; i++)
                {
                    resultado += i + 1;
                }
            }
            else
            {

                for (int i = numero1; i < numero2 - 1; i++)
                {
                    resultado += i + 1;
                }
            }

            return resultado;
        }

        private static void SolicitarNumeros(out int numero1, out int numero2)
        {
            Console.WriteLine("Ingrese el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());
        }
    }
}
