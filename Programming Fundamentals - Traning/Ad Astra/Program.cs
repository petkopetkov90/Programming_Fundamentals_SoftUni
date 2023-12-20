using System.Text.RegularExpressions;

namespace Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string foodPatter = @"(\||\#)(?<name>[A-Za-z ]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,5})\1";
            Regex regex = new Regex(foodPatter);
            List<Item> items = new List<Item>();
            int totalCalories = 0;

            foreach (Match match in regex.Matches(text))
            {
                string name = match.Groups["name"].Value;
                string date = match.Groups["date"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);
                Item item = new Item(name, date, calories);
                items.Add(item);
                totalCalories += calories;
            }

            int days = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Item
    {
        public Item(string name, string date, int calories)
        {
            Name = name;
            Date = date;
            Calories = calories;
        }
        public string Name { get; set; }
        public string Date { get; set; }
        public int Calories { get; set; }

        public override string ToString()
        {
            return $"Item: {Name}, Best before: {Date}, Nutrition: {Calories}";
        }
    }
}
