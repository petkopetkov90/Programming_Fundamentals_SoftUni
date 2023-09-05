using System;
using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            BigInteger snolballValue = int.MinValue;
            string output = string.Empty;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger ballValue = BigInteger.Pow(snow / time, quality);

                if (ballValue >= snolballValue)
                {
                    snolballValue = ballValue;
                    output = $"{snow} : {time} = {ballValue} ({quality})";
                }
            }
            Console.WriteLine(output);
        }
    }
}