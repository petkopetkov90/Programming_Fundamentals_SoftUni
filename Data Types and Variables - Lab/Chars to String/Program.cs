using System;

namespace Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char last = char.Parse(Console.ReadLine());

            Console.WriteLine($"{first}{second}{last}");
        }
    }
}