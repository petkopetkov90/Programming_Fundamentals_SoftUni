using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            double totalPriceAllOrders = 0;
            
            for (int i = 0; i < orders; i++)
            {
                double orderPrice = 0;
                double priceCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());
                orderPrice = days * capsules * priceCapsule;
                totalPriceAllOrders += orderPrice;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            }

            Console.WriteLine($"Total: ${totalPriceAllOrders:f2}");
        }
    }
}