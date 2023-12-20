using System.Numerics;

namespace Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFactorial(number));
        }

        static BigInteger GetFactorial(BigInteger number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number *= GetFactorial(number - 1);
        }
    }
}