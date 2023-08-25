using System;

namespace English_Name_of_the_Last_Digit
{
    internal class Program
    {
        static void EnglishSpelling(int num)
        {
            int lastDigit = num % 10;
            string output = string.Empty;
            switch (lastDigit)
            {
                case 0: output = "zero"; break;
                case 1: output = "one"; break;
                case 2: output = "two"; break;
                case 3: output = "three"; break;
                case 4: output = "four"; break;
                case 5: output = "five"; break;
                case 6: output = "six"; break;
                case 7: output = "seven"; break;
                case 8: output = "eight"; break;
                case 9: output = "nice"; break;
            }
            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            EnglishSpelling(number);

        }
    }
}