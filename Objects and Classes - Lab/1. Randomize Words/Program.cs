namespace Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split()
                .ToList();

            Random random = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int index = random.Next(words.Count);
                string currentWord = words[i];
                words[i] = words[index];
                words[index] = currentWord;
            }

            Console.WriteLine(string.Join("\r\n", words));
        }
    }
}