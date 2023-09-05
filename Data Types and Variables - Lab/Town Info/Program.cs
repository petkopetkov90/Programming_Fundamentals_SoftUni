using System;

namespace Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            uint area = uint.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}