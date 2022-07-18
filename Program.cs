using System;

namespace T09Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones empleado = new Operaciones();
            empleado.Suma();
            empleado.Division();
            empleado.Multiplicacion();
            empleado.Resta();
        }

        class Operaciones
        {
            private double valorA;
            private double valorB;

            public Operaciones()
            {
                Console.WriteLine("Escriba el valor A:");
                valorA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Escriba el valor B:");
                valorB = Convert.ToDouble(Console.ReadLine());
            }

            public void Suma()
            {
                Console.WriteLine("La suma de A y B es: " + (valorA + valorB));
            }

            public void Resta()
            {
                Console.WriteLine("La resta de A y B es: " + (valorA - valorB));
            }

            public void Division()
            {
                Console.WriteLine("La división de A y B es: " + (valorA / valorB));
            }

            public void Multiplicacion()
            {
                Console.WriteLine("La nultiplicación de A y B es: " + (valorA * valorB));
            }
        }
    }
}