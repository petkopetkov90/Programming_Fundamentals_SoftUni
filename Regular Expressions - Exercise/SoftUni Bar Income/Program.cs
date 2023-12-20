using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal income = 0m;
            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Regex regex = new Regex(@"%(?<name>[A-Z][a-z]+)%(?:[^$.|%]*?)<(?<productName>\w+)>(?:[^$.|%]*?)\|(?<count>\d+)\|(?:[^$.|%]*?)(?<price>\d+(?:\.\d+)?)\$");
                Match match = regex.Match(input);
                if (!match.Success)
                {
                    continue;
                }
                string customerName = match.Groups["name"].Value;
                string productName = match.Groups["productName"].Value;
                decimal count = decimal.Parse(match.Groups["count"].Value);
                decimal price = decimal.Parse(match.Groups["price"].Value);
                decimal totalPrice = price * count;
                Console.WriteLine($"{customerName}: {productName} - {totalPrice:f2}");
                income += totalPrice;
            }
            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
