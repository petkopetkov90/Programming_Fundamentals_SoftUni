namespace Bit_at_Position_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = number >> 1;
            //string binarynumber = Convert.ToString(number, 2);
            //Console.WriteLine(binarynumber[binarynumber.Length - 1]);
            int lsn = number & 1;
            Console.WriteLine(lsn);
        }
    }
}
