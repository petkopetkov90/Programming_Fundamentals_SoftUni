using System.Text;
using System.Text.RegularExpressions;

namespace Rage_Quit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            string patter = @"(?<text>\D+)(?<count>\d{0,2})";
            Regex regex = new Regex(patter);
            MatchCollection matches = regex.Matches(input);
            StringBuilder rageBuilder = new StringBuilder();

            foreach (Match match in matches)
            {
                string text = match.Groups["text"].Value;
                int count = int.Parse(match.Groups["count"].Value);
                for (int i = 0; i < count; i++)
                {
                    rageBuilder.Append(text);
                }
            }

            string rageText = rageBuilder.ToString();
            int symbolsCount = rageText.Distinct().Count();

            Console.WriteLine($"Unique symbols used: {symbolsCount}");
            Console.WriteLine($"{rageText}");
        }
    }
}
