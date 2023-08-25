using System;
using System.Diagnostics.CodeAnalysis;

namespace Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            double sum = num1 + num2 + num3;
            double maxNum = double.MinValue;
            double minNum = double.MaxValue;
            
            if (num1 > maxNum)
            {
                maxNum = num1;
            }
            if (num2 > maxNum)
            {
                maxNum = num2;
            }
            if (num3 > maxNum)
            {
                maxNum = num3;
            }

            if (num1 < minNum)
            {
                minNum = num1;
            }
            if (num2 < minNum)
            {
                minNum = num2;
            }
            if (num3 < minNum)
            {
                minNum = num3;
            }

            double middleNum = sum - maxNum - minNum;

            Console.WriteLine(maxNum);
            Console.WriteLine(middleNum);
            Console.WriteLine(minNum);

        }
    }
}