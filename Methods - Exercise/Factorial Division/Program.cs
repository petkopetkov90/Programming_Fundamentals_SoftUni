namespace Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            double result = FactorialOfInteger(number1) / FactorialOfInteger(number2);
            Console.WriteLine($"{result:f2}");

        }
        static double FactorialOfInteger(int number)
        {
            if (number <= 1)
            {
                return 1;
            }

            return number * FactorialOfInteger(number -1);
        }
    }
}