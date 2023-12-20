namespace Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine()
                .Split("|")
                .ToList();

            List<int> numbers = new List<int>();

            for (int i = 0; i < arrays.Count; i++)
            {
                List<int> currentNumbers = arrays[arrays.Count - 1 - i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                for (int j = 0; j < currentNumbers.Count; j++)
                {
                    numbers.Add(currentNumbers[j]);
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}