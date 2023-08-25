using System;

namespace Foreign_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            string output = string.Empty;

            switch (country)
            {
                case "England":
                case "USA":
                    output = "English"; break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    output = "Spanish"; break;
                default: output = "unknown"; break;
            }

            Console.WriteLine(output);
        }
    }
}