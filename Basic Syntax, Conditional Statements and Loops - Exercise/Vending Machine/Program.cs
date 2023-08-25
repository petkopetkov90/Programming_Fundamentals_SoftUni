using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startOrCoin = Console.ReadLine();

            double sum = 0;

            while (startOrCoin != "Start")
            {
                double coin = double.Parse(startOrCoin);
                
                if (coin == 0.1)
                {
                    sum += 0.10;
                }
                else if (coin == 0.2)
                {
                    sum += 0.20;
                }
                else if (coin == 0.5)
                {
                    sum += 0.50;
                }
                else if (coin == 1)
                {
                    sum += 1;
                }
                else if (coin == 2)
                {
                    sum += 2;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                startOrCoin = Console.ReadLine();
            }

            string product = Console.ReadLine();

            double sumOfPurchased = 0;

            while (product != "End")
            {
                double sumOfProduct = 0;

                bool invalidProduct = false;

                if (product == "Nuts")
                {
                    sumOfProduct += 2.0;
                }
                else if (product == "Water")
                {
                    sumOfProduct += 0.7;
                }
                else if (product == "Crisps")
                {
                    sumOfProduct += 1.5;
                }
                else if (product == "Soda")
                {
                    sumOfProduct += 0.8;
                }
                else if (product == "Coke")
                {
                    sumOfProduct += 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    invalidProduct = true;
                }

                if (!invalidProduct)
                {
                    if (sumOfProduct + sumOfPurchased > sum)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        sumOfPurchased += sumOfProduct;
                    }
                }
                product = Console.ReadLine();
            }

            double change = sum - sumOfPurchased;
            Console.WriteLine($"Change: {change:f2}");
        }
    }
}