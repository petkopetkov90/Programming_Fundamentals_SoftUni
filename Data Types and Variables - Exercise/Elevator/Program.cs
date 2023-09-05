using System;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int personsPerTrip = int.Parse(Console.ReadLine());

            int trips = persons / personsPerTrip;

            if (persons % personsPerTrip != 0)
            {
                trips++;
            }

            Console.WriteLine(trips);
        }
    }
}