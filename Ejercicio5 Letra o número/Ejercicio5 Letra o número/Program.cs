using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*5- Letra o número
Escriba un programa que determine si un carácter ingresado es letra, número, o ninguno de
los dos. En caso de que sea letra, determine si es mayúscula o minúscula.
Ingrese carácter: 9
Es número.
Ingrese carácter: A
Es letra mayúscula.
Ingrese carácter: f
Es letra minúscula.
Ingrese carácter: #
No es letra ni número.

Tip: Utilice los métodos estáticos ofrecidos por el type Char
( https://msdn.microsoft.com/es-es/library/system.char%28v=vs.110%29.aspx )
*/

namespace Ejercicio5_Letra_o_número
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter = IngresoDeCaracter();
            DeterminarCaracter(caracter);

            Console.WriteLine("\nIngrese una tecla para continuar...");
            Console.ReadKey();

        }

        private static void DeterminarCaracter(char caracter)
        {
            if (Char.IsNumber(caracter))
            {
                Console.WriteLine("\nEl caracter {0} es un numero", caracter);
            }
            else if (Char.IsLetter(caracter))
            {
                if (Char.IsUpper(caracter))
                {
                    Console.WriteLine("\nEl caracter es letra {0} Mayuscula", caracter);
                }
                else
                {
                    Console.WriteLine("\nEl caracter es letra {0} Minuscula", caracter);
                }

            }
            else
            {
                Console.WriteLine("\nEl caracter {0} no es un número ni una letra", caracter);
            }
        }

        private static char IngresoDeCaracter()
        {
            Console.WriteLine("Ingrese un caracter: ");
            char caracter = Console.ReadKey().KeyChar;
            return caracter;
        }
    }
}
