using System;
using System.Collections.Generic;

namespace FrameworkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int number = int.Parse(Console.ReadLine());

            List<int> factors = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                int result = number % i;
                if (result == 0)
                    factors.Add(i);

                Console.WriteLine("Result:" + result);
            }

            string outputFacotrs = string.Join(" ", factors.ToArray());
            Console.WriteLine("Números divisores: " + outputFacotrs);
        }
    }
}
