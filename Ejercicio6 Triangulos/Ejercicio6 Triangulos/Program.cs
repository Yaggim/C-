using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Los tres lados a , b y c de un triángulo deben satisfacer la desigualdad triangular : 
cada uno de los lados no puede ser más largo que la suma de los otros dos.

Escriba un programa que reciba como entrada los tres lados de un triángulo, e indique:
•	si acaso el triángulo es inválido; y
•	si no lo es, qué tipo de triángulo es.
Ingrese a: 3.9
Ingrese b: 6.0
Ingrese c: 1.2
No es un triángulo valido.
Ingrese a: 1.9
Ingrese b: 2
Ingrese c: 2
El triángulo es isósceles.
Ingrese a: 3.0
Ingrese b: 5.0
Ingrese c: 4.0
El triángulo es escaleno.
*/

namespace Ejercicio6_Triangulos
{

    class Triangulo
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;

        public Triangulo(double _ladoA, double _ladoB, double _ladoC)
        {
            ladoA = _ladoA;
            ladoB = _ladoB;
            ladoC = _ladoC;
        }

        public double LadoA
        {
            get
            {
                return ladoA;
            }
            set
            {
                ladoA = value;
            }
        }

        public double LadoB
        {
            get
            {
                return ladoB;
            }
            set
            {
                ladoB = value;
            }
        }

        public double LadoC
        {
            get
            {
                return ladoC;
            }
            set
            {
                ladoC = value;
            }
        }


        public void EsTriangulo()
        {
            if(ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB)
            {
                TipoDeTriangulo();
            }
            else
            {
                Console.WriteLine("No es un triangulo");
            }
        }
        public void TipoDeTriangulo()
        {
            if(ladoA==ladoB && ladoA == ladoC)
            {
                Console.WriteLine("El triangulo es equilatero");
            }else if(ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
            {
                Console.WriteLine("El triangulo es isoceles");
            }
            else
            {
                Console.WriteLine("El triangulo es escaleno");
            }
        }


    }


    class Program
    {

        static void Main(string[] args)
        {
           
            DefinirTriangulos(out Triangulo t4, out Triangulo t2, out Triangulo t3);

            PedirAlUsuarioLados(out double lado1, out double lado2, out double lado3, out Triangulo t1);

            MostrarTriangulos(t4, t2, t3, t1);

            Console.ReadKey();
        }

        private static void DefinirTriangulos(out Triangulo t4, out Triangulo t2, out Triangulo t3)
        {
            t4 = new Triangulo(3.9, 6.0, 1.2);
            t2 = new Triangulo(1.9, 2, 2);
            t3 = new Triangulo(3.0, 5.0, 4.0);
        }

        private static void PedirAlUsuarioLados(out double lado1, out double lado2, out double lado3, out Triangulo t1)
        {
            Console.WriteLine("Ingrese el lado 1 del triangulo: ");
            lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 2 del triangulo: ");
            lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 3 del triangulo: ");
            lado3 = double.Parse(Console.ReadLine());

            t1 = new Triangulo(lado1, lado2, lado3);
        }

        private static void MostrarTriangulos(Triangulo t4, Triangulo t2, Triangulo t3, Triangulo t1)
        {
            Console.WriteLine("\nObjeto 1: {0} - {1} - {2}", t1.LadoA, t1.LadoB, t1.LadoC);
            t1.EsTriangulo();
            Console.WriteLine("\nObjeto 2: {0} - {1} - {2}", t2.LadoA, t2.LadoB, t2.LadoC);
            t2.EsTriangulo();
            Console.WriteLine("\nObjeto 3: {0} - {1} - {2}", t3.LadoA, t3.LadoB, t3.LadoC);
            t3.EsTriangulo();
            Console.WriteLine("\nObjeto 4: {0} - {1} - {2}", t4.LadoA, t4.LadoB, t4.LadoC);
            t4.EsTriangulo();
        }
    }
}
