using System;

namespace Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char @char = char.Parse(Console.ReadLine());

            bool isTrue = Char.IsUpper(@char);

            if (isTrue)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}