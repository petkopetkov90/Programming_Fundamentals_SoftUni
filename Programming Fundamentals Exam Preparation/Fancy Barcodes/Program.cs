using System.Text;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int expectedInputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < expectedInputs; i++)
            {
                string barcode = Console.ReadLine();
                string patter = @"\@\#+([A-Z]+[A-Za-z\d]{4,}[A-Z]+)\@";  // ^
                Regex regex = new Regex(patter);
                if (regex.IsMatch(barcode))
                {
                    StringBuilder codeBuilder = new StringBuilder();
                    Regex digitRegex = new Regex(@"\d");
                    foreach (Match match in digitRegex.Matches(barcode))
                    {
                        codeBuilder.Append(match.Value);
                    }
                    string code = codeBuilder.ToString();
                    if (codeBuilder.Length < 1)
                    {
                        code = "00";
                    }
                    Console.WriteLine($"Product group: {code}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
