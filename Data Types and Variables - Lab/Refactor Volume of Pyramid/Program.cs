using System;

namespace Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Length: ");
            double wide = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            decimal volume = (decimal)(lenght * wide * height) / 3.0m;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");

        }
    }
}