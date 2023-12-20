using System.Text.RegularExpressions;

namespace Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(^|(?<=\s))(?<user>[A-Za-z\d]+[\.\-_]?[A-Za-z\d]+)\@(?<host>[A-Za-z]+[\-]*[A-Za-z]+(\.([A-Za-z]+[\-]*[A-Za-z]+))+)(\b|(?=\s))";
            Regex regex = new Regex(pattern);


            foreach (Match email in regex.Matches(text))
            {
                Console.WriteLine(email.ToString());
            }
        }
    }
}
