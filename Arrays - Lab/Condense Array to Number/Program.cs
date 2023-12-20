using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            while (numbers.Length > 1)
            {
                int[] newArray = new int[numbers.Length - 1];

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    newArray[i] = numbers[i] + numbers[i + 1];
                }

                numbers = newArray;
            }

            Console.WriteLine(string.Join("",numbers));
        }
    }
}