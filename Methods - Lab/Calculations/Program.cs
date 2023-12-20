using System.ComponentModel.Design;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string calculation = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            Calculate(calculation, number1, number2);
        }

        static void Calculate(string calculation, int a, int b)
        {
            if (calculation == "add")
            {
                Console.WriteLine(a + b);
            }
            else if (calculation == "multiply")
            {
                Console.WriteLine(a * b);
            }
            else if (calculation == "subtract")
            {
                Console.WriteLine(a - b);
            }
            else
            {
                Console.WriteLine(a / b);
            }
        }
    }
}