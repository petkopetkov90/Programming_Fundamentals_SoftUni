using System.Text;
using System.Text.RegularExpressions;

namespace Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string encryptedText;
            List<string> kids = new List<string>();

            while ((encryptedText = Console.ReadLine()) != "end")
            {
                StringBuilder decrybtedStringBuilder = new StringBuilder();

                foreach (char symbol in encryptedText)
                {
                    decrybtedStringBuilder.Append((char)(symbol - key));
                }

                string decryptedText = decrybtedStringBuilder.ToString();
                Regex regex = new Regex(@"\@(?<name>[A-Za-z]+)[^\@\-\!\:\>]*\!(?<behavior>G|N)\!");

                foreach (Match match in regex.Matches(decryptedText))
                {
                    string name = match.Groups["name"].Value;
                    string behavior = match.Groups["behavior"].Value;
                    if (behavior == "G")
                    {
                        kids.Add(name);
                    }
                }

            }

            Console.WriteLine(string.Join("\n",kids));
        }
    }
}
