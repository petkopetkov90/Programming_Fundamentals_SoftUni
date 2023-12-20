namespace Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> charCountPairs = new Dictionary<char, int>();

            foreach (char @char in text.Where(x => x != ' '))
            {
                if (!charCountPairs.ContainsKey(@char))
                {
                    charCountPairs.Add(@char, 0);
                }

                charCountPairs[@char] += 1;
            }

            foreach (KeyValuePair<char, int> pair in charCountPairs)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}