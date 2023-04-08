using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Cuando la Tierra completa una órbita alrededor del Sol, no han transcurrido exactamente
365 rotaciones sobre sí misma, sino un poco más. Más precisamente, la diferencia es de más o menos un cuarto
de día.
Para evitar que las estaciones se desfasen con el calendario,
el calendario juliano introdujo la regla de introducir un día adicional en los años
divisibles por 4 (llamados bisiestos ), para tomar en consideración los cuatro cuartos de día acumulados.
Sin embargo, bajo esta regla sigue habiendo un desfase, que es de aproximadamente 3/400
de día.
Para corregir este desfase, en el año 1582 el papa Gregorio XIII introdujo un nuevo calendario,
en el que el último año de cada siglo dejaba de ser bisiesto, a no ser que fuera divisible por 400.
Escriba un programa que indique si un año es bisiesto o no, 
teniendo en cuenta cuál era el calendario vigente en ese año:

Ingrese un año: 1988
1988 es bisiesto
Ingrese un año: 2011
2011 no es bisiesto
Ingrese un año: 1700
1700 no es bisiesto
Ingrese un año: 1500
1500 es bisiesto
Ingrese un año: 2400
2400 es bisiesto
*/


namespace Ejercicio8_Años_bisiestos
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio;

            anio = SolicitudDeAnio();

            CalculoDeBisiesto(anio);

            Console.ReadKey();
        }

        private static int SolicitudDeAnio()
        {
            int anio;
            Console.WriteLine("Ingrese un anio: ");
            anio = int.Parse(Console.ReadLine());
            return anio;
        }

        private static void CalculoDeBisiesto(int anio)
        {
            if (anio % 4 == 0)
            {
                if (anio % 400 != 0 && anio % 100 == 0)
                {
                    Console.WriteLine("El anio {0} no es bisiesto", anio);
                }
                else
                {
                    Console.WriteLine("El anio {0} es bisiesto", anio);
                }
            }
            else
            {
                Console.WriteLine("El anio {0} no es bisiesto", anio);
            }
        }
    }
}
