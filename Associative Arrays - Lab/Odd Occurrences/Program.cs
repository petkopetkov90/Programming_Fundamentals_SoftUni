namespace Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().ToLower().Split().ToList();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if(!wordsCount.ContainsKey(word))
                {
                    wordsCount.Add(word, 0);
                }

                wordsCount[word]++;
            }

            string result = "";

            foreach (KeyValuePair<string, int> word in wordsCount)
            {
                if (word.Value % 2 == 1)
                {
                    result += $"{word.Key} ";
                }
            }
            Console.WriteLine(result.Trim());
        }
    }
}