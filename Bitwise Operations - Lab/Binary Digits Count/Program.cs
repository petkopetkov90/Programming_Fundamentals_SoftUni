namespace Binary_Digits_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char binaryDigit = char.Parse(Console.ReadLine());
            int count = 0;
            string binaryNumber = Convert.ToString(number, 2);
            foreach (char digit in binaryNumber)
            {
                if (digit == binaryDigit)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
