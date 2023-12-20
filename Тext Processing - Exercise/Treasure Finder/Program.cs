using System.Text;

namespace Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input;
            StringBuilder stringBuilder = new StringBuilder();

            while ((input = Console.ReadLine()) != "find")
            {
                char[] text = input.ToCharArray();

                for (int i = 0; i < text.Length; i++)
                {
                    int currentKey = GetKey(i, key);
                    char newChar = (char)(text[i] - currentKey);
                    stringBuilder.Append(newChar);
                }

                string treasureText = stringBuilder.ToString();
                stringBuilder.Clear();

                int startIndexOfType = treasureText.IndexOf('&') + 1;
                int lengthOfType = treasureText.LastIndexOf('&') - startIndexOfType;
                string type = treasureText.Substring(startIndexOfType, lengthOfType);
                int startIndexOfCoordinates = treasureText.IndexOf('<') + 1;
                int lengthOfCoordinates = treasureText.IndexOf('>') - startIndexOfCoordinates;
                string coordinates = treasureText.Substring(startIndexOfCoordinates, lengthOfCoordinates);

                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }

        private static int GetKey(int i, int[] key)
        {
            while (i >= key.Length)
            {
                i -= key.Length;
            }
            return key[i];
        }
    }
}
