namespace Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetResult(EvenSum(number), OddSum(number)));

        }
        static int GetResult(int number1, int number2)
        {
            return number1 * number2;
        }
        static int EvenSum(int number)
        {
            int result = 0;

            while (number > 0)
            {
                int currentDigit = number % 10;
                if(currentDigit % 2 == 0)
                {
                    result += currentDigit;
                }
                number = number / 10;
            }

            return result;
        }

        static int OddSum(int number)
        {
            int result = 0;

            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 == 1)
                {
                    result += currentDigit;
                }
                number = number / 10;
            }

            return result;
        }
    }
}