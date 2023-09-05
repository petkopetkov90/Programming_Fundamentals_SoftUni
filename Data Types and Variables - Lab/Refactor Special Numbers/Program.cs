using System;

namespace Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= toNum; i++)
            {
                int num  = i;
                int sum = 0;
                while (num > 0)
                {
                    int currentNum = num % 10;
                    num = num / 10;
                    sum += currentNum;
                }

                string isSpecialNum = "False";

                if (sum == 5 || sum == 7 || sum == 11) 
                {
                    isSpecialNum = "True"; 
                }

                Console.WriteLine("{0} -> {1}", i, isSpecialNum);
            }

        }
    }
}