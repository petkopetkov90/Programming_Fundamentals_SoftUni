using System;

namespace Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double diffPossible = 0.000001;

            double diff = Math.Abs(num1 - num2);

            if (diffPossible > diff)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}