using System.Text.RegularExpressions;

namespace Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex validPlaces = new Regex(@"(\=|\/)(?<place>[A-Z][A-Za-z]{2,})\1");
            MatchCollection places = validPlaces.Matches(input);
            int travelPoints = 0;
            List<string> placeList = new List<string>();
            foreach (Match validPlace in places)
            {
                travelPoints += validPlace.Groups["place"].Length;
                placeList.Add(validPlace.Groups["place"].ToString());
            }

            Console.WriteLine("Destinations: " + string.Join(", ", placeList));
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
