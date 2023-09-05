using System;

namespace Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string output = string.Empty;

            for (int i = 0; i < lines; i++)
            {
                char @char = char.Parse(Console.ReadLine());

                int fromChar = (int)@char;
                char newChar = Convert.ToChar(fromChar + key);
                output += newChar;
            }

            Console.WriteLine(output);
        }
    }
}