using System;

namespace Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte lines = byte.Parse(Console.ReadLine());
            short tank = 255;

            short inTank = 0;

            for (int i = 0; i < lines; i++)
            {
                short liters = short.Parse(Console.ReadLine());                
                if (liters + inTank > tank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                inTank += liters;
            }
            Console.WriteLine(inTank);
        }
    }
}