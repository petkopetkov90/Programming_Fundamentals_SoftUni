using System.Text;

namespace Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != text[i - 1])
                {
                    stringBuilder.Append(text[i]);
                }
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
