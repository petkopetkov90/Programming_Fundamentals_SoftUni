namespace Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parts;
            decimal total = 0;
            while ((parts = Console.ReadLine()) != "special" && parts != "regular")
            {
                if (!decimal.TryParse(parts, out decimal price) || price <= 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                total += price;
            }
            if (total == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            decimal totalCost = total * 1.20m;
            if (parts == "special")
            {
                totalCost = totalCost * 0.90m;
            }

            Console.WriteLine($"Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {total:f2}$");
            Console.WriteLine($"Taxes: {total * 0.20m:f2}$");
            Console.WriteLine($"-----------");
            Console.WriteLine($"Total price: {totalCost:f2}$");
        }
    }
}
