using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double pricePerPerson = 0.0;

            if (groupType == "Students")
            {
                switch (day)
                {
                    case "Friday": pricePerPerson = 8.45; break;
                    case "Saturday": pricePerPerson = 9.80; break;
                    case "Sunday": pricePerPerson = 10.46; break;
                }
            }
            else if (groupType == "Business")
            {
                switch (day)
                {
                    case "Friday": pricePerPerson = 10.90; break;
                    case "Saturday": pricePerPerson = 15.60; break;
                    case "Sunday": pricePerPerson = 16.00; break;
                }
            }
            else if (groupType == "Regular")
            {
                switch (day)
                {
                    case "Friday": pricePerPerson = 15.00; break;
                    case "Saturday": pricePerPerson = 20.00; break;
                    case "Sunday": pricePerPerson = 22.50; break;
                }
            }

            double totalPrice = persons * pricePerPerson;

            if (groupType == "Students" && persons >= 30)
            {
                totalPrice = totalPrice * 0.85;
            }
            if (groupType == "Business" && persons >= 100)
            {
                totalPrice = totalPrice - (10 * pricePerPerson);
            }
            if (groupType == "Regular" && persons >= 10 && persons <= 20)
            {
                totalPrice = totalPrice * 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}