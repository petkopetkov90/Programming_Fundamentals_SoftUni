namespace Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Substracts(SumOfIntegers(number1, number2), number3));
        }

        static int Substracts(int number1, int number2)
        {
            return number1 - number2;
        }

        static int SumOfIntegers(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}