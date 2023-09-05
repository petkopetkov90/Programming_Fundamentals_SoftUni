using System;

namespace From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] numbers = Console.ReadLine().Split();

                long num1 = long.Parse(numbers[0]);
                long num2 = long.Parse(numbers[1]);
                long sum = 0;
                long biggerNumber = 0;

                if (num1 >= num2)
                {
                    biggerNumber = Math.Abs(num1);
                }
                else
                {
                    biggerNumber = Math.Abs(num2);
                }
                while (biggerNumber > 0)
                {
                    sum += biggerNumber % 10;
                    biggerNumber /= 10;
                }

                Console.WriteLine(sum);
            }

        }
    }
}