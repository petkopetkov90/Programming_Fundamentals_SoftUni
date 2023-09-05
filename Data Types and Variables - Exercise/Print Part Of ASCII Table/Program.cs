using System;

namespace Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int endChar = int.Parse(Console.ReadLine());

            string output = string.Empty;

            for (int i = startChar; i <= endChar; i++)
            {
                output += (char)i + " ";
            }

            Console.WriteLine(output);
        }
    }
}