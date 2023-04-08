using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*10- Índice de masa corporal
Ejercicio sacado de http://progra.usm.cl/apunte/ejercicios/1/indice-masa-corporal.html#camp09.
El riesgo de que una persona sufra enfermedades coronarias depende de su edad y su índice de masa corporal:
edad < 45 edad ≥ 45
IMC < 22.0 bajo medio
IMC ≥ 22.0 medio alto
El índice de masa corporal es el coeficiente entre el peso del individuo en kilos y el cuadrado de su estatura en metros.
Escriba un programa que reciba como entrada la estatura, el peso y la edad de una persona, y le entregue su condición de riesgo.
*/

namespace Ejer10_Indice_de_masa_corporal
{
    class Program
    {
        static void Main(string[] args)
        {

            double estatura;
            double peso;
            int edad;
            PedidoDeDatos(out estatura, out peso, out edad);

            double IMC;

            IMC = peso / (Math.Pow(estatura, 2));

            CalculoDeRiesgo(edad, IMC);

            Console.ReadKey();
        }

        private static void CalculoDeRiesgo(int edad, double IMC)
        {
            if (edad < 45)
            {
                if (IMC < 22.0)
                {
                    Console.WriteLine("La condición de riesgo es baja");
                }
                else
                {
                    Console.WriteLine("La condición de riesgo es media");
                }
            }
            else
            {
                if (IMC < 22.0)
                {
                    Console.WriteLine("La condición de riesgo es media");
                }
                else
                {
                    Console.WriteLine("La condición de riesgo es alta");
                }

            }
        }

        private static void PedidoDeDatos(out double estatura, out double peso, out int edad)
        {
            Console.WriteLine("Ingrese su estatura en metros: ");
            estatura = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su peso en kilos: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
        }
    }
}
