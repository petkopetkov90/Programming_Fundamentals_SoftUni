namespace Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int plantsCount = int.Parse(Console.ReadLine());
            List<Plant> plants = new List<Plant>();
            for (int i = 0; i < plantsCount; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->");
                string plantName = plantInfo[0];
                double plantRarity = double.Parse(plantInfo[1]);
                if (!plants.Any(x => x.Name == plantName))
                {
                    Plant plant = new Plant(plantName, plantRarity);
                    plants.Add(plant);
                    continue;
                }

                plants.First(x => x.Name == plantName).Rarity = plantRarity;
            }

            string exhibiton;
            while ((exhibiton = Console.ReadLine()) != "Exhibition")
            {
                string[] commands = exhibiton.Split(new char[] { ':', '-' }, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = commands[0];
                string plantName = commands[1];
                Plant currentPlant = plants.FirstOrDefault(x => x.Name == plantName);
                if (currentPlant == null)
                {
                    Console.WriteLine("error");
                    continue;
                }
                if (command == "Rate")
                {
                    double rating = double.Parse(commands[2]);
                    currentPlant.Ratings.Add(rating);
                }
                else if(command == "Update")
                {
                    double rarity = double.Parse(commands[2]);
                    currentPlant.Rarity = rarity;

                }
                else if (command == "Reset")
                {
                    currentPlant.Ratings.Clear();
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            Console.WriteLine(string.Join("\n", plants));
        }
    }

    class Plant
    {
        public Plant(string name, double rarity)
        {
            Name = name;
            Rarity = rarity;
            Ratings = new List<double>();
        }
        public string Name { get; set; }
        public double Rarity { get; set; }
        public List<double> Ratings { get; set; }

        public override string ToString()
        {
            if (Ratings.Count == 0)
            {
                return $"- {Name}; Rarity: {Rarity}; Rating: 0.00";
            }
            return $"- {Name}; Rarity: {Rarity}; Rating: {Ratings.Average():f2}";
        }
    }
}
