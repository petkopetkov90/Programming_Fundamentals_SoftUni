using System.Text.RegularExpressions;

namespace Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> wordsValidPairs = new List<string>();
            Regex wordPairs = new Regex(@"(\@|\#)(?<word1>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1");
            MatchCollection matchPairs = wordPairs.Matches(text);

            if (matchPairs.Count < 1)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matchPairs.Count} word pairs found!");
            }

            foreach (Match match in matchPairs)
            {
                string word1 = match.Groups["word1"].Value;
                string word2 = match.Groups["word2"].Value;
                string reversedWord2 = new string(word2.Reverse().ToArray());
                if (word1 == reversedWord2)
                {
                    string pair = $"{word1} <=> {word2}";
                    wordsValidPairs.Add(pair);
                }
            }

            if (wordsValidPairs.Count < 1)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", wordsValidPairs));
            }
        }
    }
}
