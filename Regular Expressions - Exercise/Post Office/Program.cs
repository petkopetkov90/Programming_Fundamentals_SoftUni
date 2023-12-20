using System.Text.RegularExpressions;

namespace Post_Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToArray();
            string firstPart = input[0];
            string secondPart = input[1];
            string thirdPart = input[2];

            string startLetterPattern = @"([\#|\$|\%|\&|\*])(?<letters>[A-Za-z]+)\1";
            Regex startLetterRegex = new Regex(startLetterPattern);
            Match startLetterMatch = startLetterRegex.Match(firstPart);
            string letters = startLetterMatch.Groups["letters"].Value.ToString();
            int wordsCount = letters.Length;

            List<string> words = thirdPart.Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList();

            foreach (char letter in letters)
            {
                int letterASCII = letter + 0;
                string pattern = $@"(?<ascii>{letterASCII}):(?<length>\d{{2}})";
                Regex rangeRegex = new Regex(pattern);
                Match match = rangeRegex.Match(secondPart);
                int wordLengh = int.Parse(match.Groups["length"].Value.ToString()) + 1;

                foreach (string word in words)
                {
                    if (word[0] != letter || word.Length != wordLengh)
                    {
                        continue;
                    }

                    Console.WriteLine(word);
                }
            }
        }
    }
}
