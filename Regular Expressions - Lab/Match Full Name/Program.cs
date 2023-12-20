using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";
            MatchCollection matches = Regex.Matches(text, pattern);  
            Console.WriteLine(string.Join(" ", matches));

        }
    }
}
