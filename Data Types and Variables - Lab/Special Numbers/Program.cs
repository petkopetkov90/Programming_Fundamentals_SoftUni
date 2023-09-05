using System;

namespace Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalnums = int.Parse(Console.ReadLine());

            for (int i = 1; i <= totalnums; i++)
            {
                int num = i;
                int sum = 0;
                string output = "False";
                while (num > 0)
                {
                    int currentNum = num % 10;
                    num = num / 10;
                    sum += currentNum;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    output = "True";
                }

                Console.WriteLine($"{i} -> {output}");
            }

        }
    }
}