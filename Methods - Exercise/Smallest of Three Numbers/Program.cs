namespace Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            PringSmallestInteger(number1, number2, number3);
        }

        static void PringSmallestInteger(int number1, int number2, int number3)
        {
            Console.WriteLine(Math.Min(Math.Min(number1, number2), number3));
        }

    }
}