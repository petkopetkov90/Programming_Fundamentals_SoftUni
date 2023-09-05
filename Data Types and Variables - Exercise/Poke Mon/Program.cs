using System;

namespace Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokemonPower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());

            int targetReached = 0;
            int power = pokemonPower / 2;

            while (pokemonPower >= distance)
            {
                pokemonPower -= distance;
                targetReached++;

                if (pokemonPower == power && exhaustionFactor != 0)
                {
                    pokemonPower = pokemonPower / exhaustionFactor;
                }

            }
            Console.WriteLine(pokemonPower);
            Console.WriteLine(targetReached);
        }
    }
}