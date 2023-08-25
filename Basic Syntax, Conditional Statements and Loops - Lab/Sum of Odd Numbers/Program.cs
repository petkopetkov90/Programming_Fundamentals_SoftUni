using System;

namespace Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;

            for (int i = 1; i <= 2 * number; i+= 2)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                    counter++;
                    Console.WriteLine(i);
                    
                    if (counter == number)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}