using System.Text.RegularExpressions;

namespace Message_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputs; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"\!(?<command>[A-Z][a-z]{2,})\!\:(.??)\[(?<string>[A-Za-z]{8,})\]";
                Match match = Regex.Match(input, pattern);
                if (!match.Success)
                {
                    Console.WriteLine("The message is invalid");
                    continue;
                }
                string command = match.Groups["command"].Value;
                string text = match.Groups["string"].Value;
                char[] chars = text.ToCharArray();

                Console.Write($"{command}:");
                foreach (char c in chars)
                {
                    Console.Write($" {c + 0}");
                }
                Console.WriteLine();
            }
        }
    }
}
