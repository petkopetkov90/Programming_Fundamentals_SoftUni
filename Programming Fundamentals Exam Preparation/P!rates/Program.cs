namespace P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, City> cities = new Dictionary<string, City>();
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] cityDetails = input.Split("||", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string cityName = cityDetails[0];
                int population = int.Parse(cityDetails[1]);
                int gold = int.Parse(cityDetails[2]);
                if (!cities.ContainsKey(cityName))
                {
                    City city = new City(cityName);
                    cities.Add(cityName, city);
                }

                cities[cityName].Population += population;
                cities[cityName].Gold += gold;
            }
            while ((input = Console.ReadLine()) != "End")
            {
                string[] orders = input.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = orders[0];
                if (type == "Plunder")
                {
                    string cityName = orders[1];
                    int population = int.Parse(orders[2]);
                    int gold = int.Parse(orders[3]);
                    Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {population} citizens killed.");
                    cities[cityName].Population -= population;
                    cities[cityName].Gold -= gold;
                    if (cities[cityName].Population <= 0 || cities[cityName].Gold <= 0)
                    {
                        Console.WriteLine($"{cityName} has been wiped off the map!");
                        cities.Remove(cityName);
                    }
                }
                else if (type == "Prosper")
                {
                    string cityName = orders[1];
                    int gold = int.Parse(orders[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }

                    cities[cityName].Gold += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {cities[cityName].Gold} gold.");
                }
            }
            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (KeyValuePair<string, City> city in cities)
                {
                    Console.WriteLine(city.Value);
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }

    public class City
    {
        public City(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
        public override string ToString()
        {
            string output = string.Empty;
            output += $"{Name} -> Population: {Population} citizens, Gold: {Gold} kg";
            return output;
        }
    }
}
