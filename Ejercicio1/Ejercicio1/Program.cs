using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Escriba un programa que calcule el promedio de 4 notas ingresadas por el usuario:
Primera nota: 55
Segunda nota: 71
Tercera nota: 46
Cuarta nota: 87
El promedio es: 64.75
*/

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            int nota1;
            int nota2;
            int nota3;
            int nota4;
            float promedio;

            CalculoDeNotas(out nota1, out nota2, out nota3, out nota4);
            promedio = CalculoDePromedio(nota1, nota2, nota3, nota4);
            MostrarPromedio(promedio);
        }

        private static void MostrarPromedio(float promedio)
        {
            Console.WriteLine("El promedio es: " + promedio);

            Console.WriteLine("Escriba cualquier caracter para salir");

            Console.ReadKey();
        }

        private static float CalculoDePromedio(int nota1, int nota2, int nota3, int nota4)
        {
            return (float)(nota1 + nota2 + nota3 + nota4) / 4;
        }

        private static void CalculoDeNotas(out int nota1, out int nota2, out int nota3, out int nota4)
        {
            Console.WriteLine("Ingrese la nota 1: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3: ");
            nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 4: ");
            nota4 = int.Parse(Console.ReadLine());
        }
    }
}
