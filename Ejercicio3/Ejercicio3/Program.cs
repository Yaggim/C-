using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*3- Edad
Escriba un programa que entregue la edad del usuario a partir de su fecha de nacimiento
*/

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            DateTime fechaActual = DateTime.Now; // Obtener la fecha actual

            DateTime fechaDeNacimiento = ObtenerFechaDeNacimiento();
            edad = ObtenerEdad(fechaActual, fechaDeNacimiento);
            MostrarEdad(edad);

            Console.ReadKey();

        }

        private static void MostrarEdad(int edad)
        {
            Console.WriteLine("La edad de la persona es: " + edad);

            Console.WriteLine("Toque una tecla para continuar...");
        }

        private static int ObtenerEdad(DateTime fechaActual, DateTime fechaDeNacimiento)
        {
            int edad = fechaActual.Year - fechaDeNacimiento.Year;
            if (fechaActual.Month < fechaDeNacimiento.Month || (fechaActual.Month == fechaDeNacimiento.Month && fechaActual.Day < fechaDeNacimiento.Day))
            {
                edad--;
            }

            return edad;
        }

        private static DateTime ObtenerFechaDeNacimiento()
        {
            Console.WriteLine("Ingrese su fecha de nacimiento YYYY MM DD ");
            DateTime fechaDeNacimiento = DateTime.Parse(Console.ReadLine());
            return fechaDeNacimiento;
        }
    }
}
