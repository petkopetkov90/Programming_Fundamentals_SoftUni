namespace Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> numbers2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> mixedNumbers = new List<int>();

            int iterations = Math.Min(numbers1.Count, numbers2.Count);

            for (int i = 0; i < iterations; i++)
            {
                mixedNumbers.Add(numbers1[0]);
                numbers1.RemoveAt(0);
                mixedNumbers.Add(numbers2[numbers2.Count - 1]);
                numbers2.RemoveAt(numbers2.Count - 1);
            }

            int start = 0;
            int stop = 0;

            if (numbers1.Count >= numbers2.Count)
            {
                start = Math.Min(numbers1[0], numbers1[1]);
                stop = Math.Max(numbers1[0], numbers1[1]);
            }
            else
            {
                start = Math.Min(numbers2[0], numbers2[1]);
                stop = Math.Max(numbers2[0], numbers2[1]);
            }

            List<int> result = new List<int>();

            for (int i = 0; i < mixedNumbers.Count; i++)
            {
                if (mixedNumbers[i] > start && mixedNumbers[i] < stop)
                {
                    result.Add(mixedNumbers[i]);
                }
            }

            result.Sort();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}