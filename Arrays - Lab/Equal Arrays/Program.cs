using System;
using System.Linq;

namespace Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool areIndentical = true;

            int sumOfArray = 0;
            int index = 0;
            
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    areIndentical = false;
                    index = i;
                    break;
                }

                else
                {
                    sumOfArray += array1[i];
                }
            }

            if (areIndentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumOfArray}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }

        }
    }
}