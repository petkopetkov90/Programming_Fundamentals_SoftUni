namespace Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            SortedDictionary<int, int> integersAndCount = new SortedDictionary<int, int>();
            foreach (int number in integers)
            {
                if (!integersAndCount.ContainsKey(number))
                {
                    integersAndCount.Add(number, 0);
                }

                integersAndCount[number] += 1;
            }

            foreach (KeyValuePair<int, int> pair in integersAndCount)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}