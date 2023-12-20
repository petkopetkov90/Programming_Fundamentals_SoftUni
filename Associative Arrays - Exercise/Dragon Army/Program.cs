using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

namespace Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dragon>> dragons = new Dictionary<string, List<Dragon>>();
            int totalDragons = int.Parse(Console.ReadLine());
            for (int i = 0; i < totalDragons; i++)
            {
                string[] dragonStats = Console.ReadLine().Split();
                string type = dragonStats[0];
                string name = dragonStats[1];
                int damage;
                int health;
                int armor;
                CheckStats(dragonStats, out damage, out health, out armor);
                Dragon dragon = new Dragon(type, name, damage, health, armor);
                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new List<Dragon>());
                    dragons[type].Add(dragon);
                }
                else
                {
                    if (dragons[type].FirstOrDefault(x => x.Name == name) == null)
                    {
                        dragons[type].Add(dragon);
                    }
                    else
                    {
                        dragons[type].First(x => x.Name == name).Damage = damage;
                        dragons[type].First(x => x.Name == name).Health = health;
                        dragons[type].First(x => x.Name == name).Armor = armor;
                    }
                }

            }
            foreach (KeyValuePair<string, List<Dragon>> dragonType in dragons)
            {
                Console.WriteLine($"{dragonType.Key}::({dragonType.Value.Average(x => x.Damage):f2}/{dragonType.Value.Average(x => x.Health):f2}/{dragonType.Value.Average(x => x.Armor):f2})");
                foreach (var dragon in dragons[dragonType.Key].OrderBy(x => x.Name))
                {
                    Console.WriteLine(dragon);
                }

            }
        }

        private static void CheckStats(string[] dragonStats, out int damage, out int health, out int armor)
        {
            if (dragonStats[2] == "null")
            {
                damage = 45;
            }
            else
            {
                damage = int.Parse(dragonStats[2]);
            }
            if (dragonStats[3] == "null")
            {
                health = 250;
            }
            else
            {
                health = int.Parse(dragonStats[3]);
            }
            if (dragonStats[4] == "null")
            {
                armor = 10;
            }
            else
            {
                armor = int.Parse(dragonStats[4]);
            }
        }
    }

    public class Dragon
    {
        public Dragon(string type, string name, int damage, int health, int armor)
        {
            Type = type;
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }

        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public string Type { get; set; }
        public override string ToString()
        {
            string output = string.Empty;
            output += $"-{Name} -> damage: {Damage}, health: {Health}, armor: {Armor}";
            return output;
        }
    }
}