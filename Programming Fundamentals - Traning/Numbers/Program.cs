namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            integers = integers.Where(x => x > integers.Average())
                .OrderByDescending(x => x)
                .Take(5)
                .ToList();

            if (integers.Count < 1)
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
