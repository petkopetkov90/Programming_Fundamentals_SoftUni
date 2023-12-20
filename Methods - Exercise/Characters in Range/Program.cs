namespace Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            int char1Value = Convert.ToInt32(char1);
            int char2Value = Convert.ToInt32(char2);

            PrintCharsInRange(char1Value, char2Value);
        }

        static void PrintCharsInRange(int char1Value, int char2Value)
        {
            int start = Math.Min(char1Value, char2Value);
            int stop = Math.Max(char1Value, char2Value);

            for (int ASCII = start + 1; ASCII < stop; ASCII++)
            {
                Console.Write(Convert.ToChar(ASCII));
                if (ASCII < stop - 1)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}