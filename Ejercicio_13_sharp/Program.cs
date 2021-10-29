using System;

namespace Ejercicio_13_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int auxiliar;

            Console.Write("Introduzca un número entero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca otro número entero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            auxiliar = numero1;
            numero1 = numero2;
            numero2 = auxiliar;

            Console.WriteLine("\nVariable 1: " + numero1);
            Console.WriteLine("Variable 2: " + numero2);

        }
    }
}
