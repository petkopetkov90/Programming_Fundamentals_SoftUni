using System;

namespace Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            int timeInMins = hours * 60 + mins;

            int timeToBackInMins = timeInMins + 30;

            int hoursToBack = timeToBackInMins / 60;
            int minsToBack = timeToBackInMins % 60;

            if (hoursToBack >= 24)
            {
                hoursToBack = 0;
            }

            Console.WriteLine($"{hoursToBack}:{minsToBack:d2}");

        }
    }
}