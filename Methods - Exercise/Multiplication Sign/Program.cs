namespace Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            long result = MultipleNumbers(MultipleNumbers(number1, number2), number3);
            NumberIsPossNegOrZero(result);
        }

        static void NumberIsPossNegOrZero(long result)
        {
            if (result < 0)
            {
                Console.WriteLine("negative");
            }
            else if (result > 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }

        static int MultipleNumbers(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}