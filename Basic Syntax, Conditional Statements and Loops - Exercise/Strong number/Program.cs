using System;

namespace Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string numLengt = num.ToString();
            int oldNum = num;
            int sum = 0;

            for (int i = 0; i < numLengt.Length; i++)
            {
                int num1 = num % 10;
                num = num / 10;

                int middleSum = num1;

                for (int j = 1; j < num1; j++)
                {
                    middleSum = middleSum * j;
                }

                if (middleSum == 0)
                {
                    middleSum = 1;
                }

                sum += middleSum;
            }

            if (sum == oldNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}