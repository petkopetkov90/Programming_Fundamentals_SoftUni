namespace Odd_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                result = result ^ number[i];
            }

            Console.WriteLine(result);
        }
    }
}
