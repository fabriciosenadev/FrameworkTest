using System;
using System.Collections.Generic;

namespace FrameworkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> denominators = new List<int>();
            List<int> primeNumbers = new List<int>();

            Console.Write("Digite um número: ");
            int number = int.Parse(Console.ReadLine());

            denominators = HandleDenominatorsBySpecificInt(number, denominators);
            primeNumbers = HandlePrimeNumbersByDenominators(denominators, primeNumbers);

            string outputDenominators = ConvertListToString(" ", denominators);
            string outputPrimeNumbers = ConvertListToString(" ", primeNumbers);

            Console.WriteLine("Números divisores: " + outputDenominators);
            Console.WriteLine("Números primos: " + outputPrimeNumbers);
        }

        private static string ConvertListToString(string separator, List<int> list)
        {
            return string.Join(separator, list.ToArray());
        }

        private static List<int> HandleDenominatorsBySpecificInt(int number, List<int> denominators)
        {
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    denominators.Add(i);
            }
            return denominators;
        }
        private static List<int> HandlePrimeNumbersByDenominators(List<int> denominators, List<int> primeNumbers)
        {
            foreach (int denominator in denominators)
            {
                int count = 0;
                for (int i = denominator; i > 0; i--)
                {
                    if (denominator % i == 0)
                        count++;
                }
                if (count == 2)
                    primeNumbers.Add(denominator);
            }
            return primeNumbers;
        }
    }
}
