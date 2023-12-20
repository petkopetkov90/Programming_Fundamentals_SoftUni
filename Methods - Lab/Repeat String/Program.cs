namespace Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int timesRepeat = int.Parse(Console.ReadLine());

            Console.WriteLine(MultipleString(text, timesRepeat));

        }

        static string MultipleString(string text, int timesRepeat)
        {
            string result = text;

            for (int i = 1; i < timesRepeat; i++)
            {
                result += text;
            }

            return result;
        }
    }
}