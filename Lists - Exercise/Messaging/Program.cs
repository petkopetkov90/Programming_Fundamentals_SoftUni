using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();

            List<char> chars = text.ToList();

            string output = "";

            for (int i = 0; i < numbers.Count; i++)
            {
                int number = Math.Abs(numbers[i]);
                output += GetElement(chars, number);
            }

            Console.WriteLine(output);

        }

        static string GetElement(List<char> chars, int number)
        {
            string currentChar = "";
            int index = CalculateIndex(chars, number);
            currentChar = chars[index].ToString();
            chars.RemoveAt(index);
            return currentChar;
        }
        static int CalculateIndex(List<char> chars, int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            while (sum >= chars.Count)
            {
                sum -= chars.Count;
            }
            return sum;
        }
    }
}