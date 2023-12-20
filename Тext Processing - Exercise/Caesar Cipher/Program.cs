using System.Text;

namespace Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = (char)(text[i] + 3);
                stringBuilder.Append(currentChar);
            }

            Console.WriteLine(stringBuilder.ToString());
        } 
    }
}
