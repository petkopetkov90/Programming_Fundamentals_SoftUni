using System.Text.RegularExpressions;

namespace Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();
            decimal totalPrice = 0;
            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                string pattern = @">>(?<product>[A-Z][a-z]+|[A-Z]+)<<(?<price>\d+\.\d+|\d+)!(?<quantity>[0-9]+)";

                foreach (Match match in Regex.Matches(input, pattern))
                {
                    string product = match.Groups["product"].ToString(); // -//-
                    decimal price = decimal.Parse(match.Groups["price"].Value); // -//-
                    decimal quantity = decimal.Parse(match.Groups["quantity"].Value);
                    products.Add(product);
                    totalPrice += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");
            if (products.Count > 0)
            {
                Console.WriteLine(string.Join("\n", products));
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
