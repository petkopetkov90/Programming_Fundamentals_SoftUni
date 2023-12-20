using System.Text.RegularExpressions;

namespace Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Racer> racers = new List<Racer>();
            string[] racersNames = Console.ReadLine().Split(", ");

            foreach (string name in racersNames)
            {
                Racer racer = new Racer();
                racer.Name = name;
                racer.Distance = 0;
                racers.Add(racer);
            }

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                Regex regex = new Regex(@"[^[A-Za-z]");
                string replacement = "";
                string name = regex.Replace(input, replacement);
                if (racers.Any(x => x.Name == name))
                {
                    regex = new Regex(@"[^0-9]");
                    string distanceString = regex.Replace(input, replacement);
                    int distance = 0;
                    foreach (char distanceChar in distanceString)
                    {
                        distance += int.Parse(distanceChar.ToString());
                    }
                    racers.First(x => x.Name == name).Distance += distance;
                }
            }
            racers = racers.OrderByDescending(x => x.Distance).Take(3).ToList();
            Console.WriteLine($"1st place: {racers[0].Name}");
            Console.WriteLine($"2nd place: {racers[1].Name}");
            Console.WriteLine($"3rd place: {racers[2].Name}");
        }
    }
    public class Racer
    {
        public string Name { get; set; }
        public int Distance { get; set; }
    }
}
