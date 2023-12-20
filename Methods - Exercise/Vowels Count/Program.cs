namespace Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(GetVowelsCount(input.ToLower()));
        }

        static int GetVowelsCount(string text)
        {
            int cout = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
                {
                    cout++;
                }
            }
            return cout;
        }
    }
}