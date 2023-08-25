using System;

namespace Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double toalLighsabersNeed = Math.Ceiling(students * 1.10);
            double totalBletsNeeded = students - (students / 6);
            double totalRobesNeeded = students;

            double totalCost = toalLighsabersNeed * priceOfLightsaber + totalBletsNeeded * priceOfBelt + totalRobesNeeded * priceOfRobe;

            if (money >= totalCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalCost - money:f2}lv more.");
            }

        }
    }
}