using System;

namespace Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isEven = false;

            while (!isEven) 
            {
                int num = int.Parse(Console.ReadLine());

                if(num % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    isEven = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}