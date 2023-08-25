using System;

namespace Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyHave = double.Parse(Console.ReadLine());

            bool gameTime = false;
            double moneySpend = 0;

            while (!gameTime)
            {
                string game = Console.ReadLine();

                if (game == "Game Time")
                {
                    gameTime = true;
                    break;
                }

                double gamePrice = 0;
                
                switch (game)
                {
                    case "OutFall 4": gamePrice = 39.99; break;
                    case "CS: OG": gamePrice = 15.99; break;
                    case "Zplinter Zell": gamePrice = 19.99; break;
                    case "Honored 2": gamePrice = 59.99; break;
                    case "RoverWatch": gamePrice = 29.99; break;
                    case "RoverWatch Origins Edition": gamePrice = 39.99; break;
                    default: gamePrice = 0; break;
                }

                if (gamePrice == 0)
                {
                    Console.WriteLine($"Not Found");
                    continue;
                }
                else if (moneyHave < gamePrice + moneySpend)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                else
                {
                    moneySpend += gamePrice;

                    Console.WriteLine($"Bought {game}");

                    if (moneyHave == moneySpend)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
            }
            if (gameTime)
            {
                Console.WriteLine($"Total spent: ${moneySpend:f2}. Remaining: ${moneyHave - moneySpend:f2}");
            }

        }
    }
}