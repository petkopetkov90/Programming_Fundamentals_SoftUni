namespace Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstChar = char.Parse(Console.ReadLine());
            int secondChar = char.Parse(Console.ReadLine());
            char[] text = Console.ReadLine().ToCharArray();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                int currentChar = text[i];
                if (currentChar > firstChar && currentChar < secondChar)
                {
                    sum += currentChar;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
