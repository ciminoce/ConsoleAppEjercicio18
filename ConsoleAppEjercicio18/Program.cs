using System;

namespace ConsoleAppEjercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero:");
            
            var numero = int.Parse(Console.ReadLine());
            if (numero>=0)
            {
                Console.WriteLine($"{numero} es positivo");
            }
            else
            {
                Console.WriteLine($"{numero} es negativo");
            }

            Console.ReadLine();
        }
    }
}
