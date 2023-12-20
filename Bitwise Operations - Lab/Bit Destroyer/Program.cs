namespace Bit_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int possition = int.Parse(Console.ReadLine());
            int mask = 1 << possition;
            mask = ~mask;
            number = number & mask;
            Console.WriteLine(number);
        }
    }
}
