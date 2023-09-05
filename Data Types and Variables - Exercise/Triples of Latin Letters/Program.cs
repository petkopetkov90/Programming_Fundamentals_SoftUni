using System;

namespace Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int firstChar = 0; firstChar < number; firstChar++)
            {
                char firstASCII = (char)(firstChar + 97);

                for (int secondChar = 0; secondChar < number; secondChar++)
                {
                    char secondASCII = (char)(secondChar + 97);

                    for (int lastChar = 0; lastChar < number; lastChar++)
                    {
                        char lastASCII = (char)(lastChar + 97);

                        Console.WriteLine($"{firstASCII}{secondASCII}{lastASCII}");
                    }
                }
            }
        }
    }
}