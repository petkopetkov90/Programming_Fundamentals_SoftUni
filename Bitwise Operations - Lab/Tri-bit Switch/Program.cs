namespace Tri_bit_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int possitionStart3bits = int.Parse(Console.ReadLine());
            int mask = 7 << possitionStart3bits;
            int result = number ^ mask;
            Console.WriteLine(result);
            
        }
    }
}
