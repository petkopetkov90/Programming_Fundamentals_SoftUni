namespace Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordAndSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < inputCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!wordAndSynonyms.ContainsKey(word))
                {
                    wordAndSynonyms.Add(word, new List<string>());
                }

                wordAndSynonyms[word].Add(synonym);
            }

            foreach (KeyValuePair<string, List<string>> pair in wordAndSynonyms)
            {
                Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
            }
        }
    }
}