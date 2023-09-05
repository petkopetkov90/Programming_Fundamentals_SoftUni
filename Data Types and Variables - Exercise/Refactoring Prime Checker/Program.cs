using System;

namespace Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int number = 2; number <= range; number++)
            {
                bool isPrime = true;

                for (int divider = 2; divider < number; divider++)
                {
                    if (number % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("{0} -> true", number);
                }
                else
                {
                    Console.WriteLine("{0} -> false", number);
                }
            }

        }
    }
}