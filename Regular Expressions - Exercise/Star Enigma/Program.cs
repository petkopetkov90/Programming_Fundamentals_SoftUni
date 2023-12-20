using System.Text;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputs = int.Parse(Console.ReadLine());
            List<Planet> planets = new List<Planet>();

            for (int i = 0; i < inputs; i++)
            {
                string encryptedMSG = Console.ReadLine();
                Regex decrypting = new Regex(@"[SsTtAaRr]");
                MatchCollection matches = decrypting.Matches(encryptedMSG);
                int keyCount = matches.Count();
                StringBuilder decryptedMSMBuilder = new StringBuilder();

                foreach (char @char in encryptedMSG)
                {
                    char newChar = (char)(@char - keyCount);
                    decryptedMSMBuilder.Append(newChar);
                }

                string decryptedMSG = decryptedMSMBuilder.ToString();
                Regex extractions = new Regex(@"\@(?<planet>[A-Za-z]+)(?:[^\@\-\!\:\>]*)\:(?<population>\d+)(?:[^\@\-\!\:\>]*)\!(?<attackType>A|D)\!(?:[^\@\-\!\:\>]*)\-\>(?<soldiers>\d+)");
                Match match = extractions.Match(decryptedMSG);

                if (match.Success)
                {
                    Planet planet = new Planet();
                    planet.Name = match.Groups["planet"].Value;
                    planet.Population = int.Parse(match.Groups["population"].Value);
                    planet.AttackType = match.Groups["attackType"].Value;
                    planet.Soldiers = int.Parse(match.Groups["soldiers"].Value);
                    planets.Add(planet);
                }
            }

            List<Planet> attackedPlanets = planets.Where(x => x.AttackType == "A").OrderBy(x => x.Name).ToList();
            List<Planet> destroyedPlanets = planets.Where(x => x.AttackType == "D").OrderBy(x => x.Name).ToList();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (Planet planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet.Name}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (Planet planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet.Name}");
            }
        }
    }

    class Planet
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public string AttackType { get; set; }
        public int Soldiers { get; set; }
    }
}
