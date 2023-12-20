using System;
using System.Linq;

namespace Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int[] numbers = new int[numbersCount];

            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            //for (int i = numbersCount - 1; i >= 0; i--)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            Array.Reverse(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}