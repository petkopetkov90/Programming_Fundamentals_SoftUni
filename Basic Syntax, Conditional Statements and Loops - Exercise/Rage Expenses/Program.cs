using System;

namespace Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gamesLoss = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetBroken = 0;
            int mouseBroken = 0;
            int keyboardBroken = 0;

            for (int game = 1; game <= gamesLoss; game++)
            {
                if (game % 2 == 0)
                {
                    headsetBroken++;
                }
                if (game % 3 == 0)
                {
                    mouseBroken++;
                }
                if (game % 2 == 0 && game % 3 == 0)
                {
                    keyboardBroken++;
                }
            }

            int displayBroken = keyboardBroken / 2;

            double headsetCost = headsetBroken * headsetPrice;
            double mouseCost = mouseBroken * mousePrice;
            double keyboardCost = keyboardBroken * keyboardPrice;
            double displayCost = displayBroken * displayPrice;

            double totalCost = headsetCost + mouseCost + keyboardCost + displayCost;

            Console.WriteLine($"Rage expenses: {totalCost:f2} lv.");
        }
    }
}