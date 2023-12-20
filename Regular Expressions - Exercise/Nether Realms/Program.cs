using System.Text.RegularExpressions;

namespace Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(",", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToArray();
            SortedDictionary<string, Demon> demons = new SortedDictionary<string, Demon>();
            for (int i = 0; i < input.Length; i++)
            {
                string demonName = input[i];
                Demon demon = new Demon(demonName);
                Regex regex = new Regex(@"[\d\+\-\*\/\.]");
                char[] healthName = regex.Replace(demonName, "").ToCharArray();
                foreach (char healthChar in healthName)
                {
                    demon.Health += healthChar;
                }
                regex = new Regex (@"[\+|\-]*(\d+(\.\d+)*)");
                MatchCollection matches = regex.Matches(demonName);
                foreach (Match match in matches)
                {
                    demon.Damage += double.Parse(match.Value);
                    
                }
                regex = new Regex(@"[\*|\/]");
                matches = regex.Matches(demonName);
                foreach (Match match in matches)
                {
                    if (match.Value == "*")
                    {
                        demon.Damage = demon.Damage * 2.0;
                    }
                    else if (match.Value == "/")
                    {
                        demon.Damage = demon.Damage / 2.0;
                    }
                }

                demons.Add(demonName, demon);

            }
            foreach (KeyValuePair<string, Demon> demon in demons)
            {
                Console.WriteLine($"{demon.Value.Name} - {demon.Value.Health} health, {demon.Value.Damage:f2} damage");
            }
        }
    }

    class Demon
    {
        public Demon(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public double Health { get; set; }
        public double Damage { get; set; }
    }
}
