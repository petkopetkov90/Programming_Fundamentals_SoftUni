using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?:^|\s)(?:\+359)(-| )2\1\d{3}\1\d{4}\b";
            Regex regex = new Regex(pattern);
            string text = Console.ReadLine();
            MatchCollection matches = regex.Matches(text);
            Console.WriteLine(string.Join(", ", matches.Select(x => x.Value.Trim())));
        }
    }
}
