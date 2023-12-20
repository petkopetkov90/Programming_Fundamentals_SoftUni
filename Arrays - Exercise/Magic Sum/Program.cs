namespace Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int iNext = i + 1; iNext < numbers.Length; iNext++)
                {
                    if (numbers[i] + numbers[iNext] == sum)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[iNext]}");
                    }
                }
            }
        }
    }
}