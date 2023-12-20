using System.Numerics;
using System.Text.RegularExpressions;

namespace Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            BigInteger coolNumber = 1;
            Regex regex = new Regex(@"\d");
            foreach (Match match in regex.Matches(text))
            {
                coolNumber *= BigInteger.Parse(match.Value);
            }

            List<string> emojis = new List<string>();
            regex = new Regex(@"(\:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1");
            int coolEmojis = 0;
            foreach (Match match in regex.Matches(text))
            {
                coolEmojis++;
                BigInteger sum = 0;
                foreach (char @char in match.Groups["emoji"].Value)
                {
                    sum += @char;

                }
                if (sum >= coolNumber)
                {
                    emojis.Add(match.Value.ToString());
                }
            }

            Console.WriteLine($"Cool threshold: {coolNumber}");
            Console.WriteLine($"{coolEmojis} emojis found in the text. The cool ones are:");
            foreach (string emoji in emojis)
            {
                    Console.WriteLine($"{emoji}");
            }
        }
    }
}
