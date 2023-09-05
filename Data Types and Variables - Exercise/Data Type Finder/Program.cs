using System;

namespace Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string type = string.Empty;

                if (int.TryParse(input, out int integer))
                {
                    type = "integer";
                }
                else if (float.TryParse(input, out float floated))
                {
                    type = "floating point";
                }
                else if (char.TryParse(input, out char character))
                {
                    type = "character";
                }
                else if (bool.TryParse(input, out bool isTrue))
                {
                    type = "boolean";
                }
                else
                {
                    type = "string";
                }

                Console.WriteLine($"{input} is {type} type");

                input = Console.ReadLine();
            }
        }
    }
}