namespace Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            decimal priceWithoutTax = 0;
            while ((input = Console.ReadLine()) != "special" && input != "regular")
            {
                decimal price = decimal.Parse(input);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                priceWithoutTax += price;
            }
            decimal priceWithTax = priceWithoutTax * 1.20m;
            decimal taxes = priceWithTax - priceWithoutTax;
            if (priceWithoutTax == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            if (input == "special")
            {
                priceWithTax *= 0.90m;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {priceWithoutTax:F2}$");
            Console.WriteLine($"Taxes: {taxes:F2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {priceWithTax:f2}$");
        }
    }
}