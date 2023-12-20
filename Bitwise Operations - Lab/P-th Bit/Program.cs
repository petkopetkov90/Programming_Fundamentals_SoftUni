namespace P_th_Bit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int possitions = int.Parse(Console.ReadLine());
            number = number >> possitions;
            int result = number & 1;
            Console.WriteLine(result);
        }
    }
}
