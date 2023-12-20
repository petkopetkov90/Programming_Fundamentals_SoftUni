
namespace Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            string text1 = text[0];
            string text2 = text[1];

            Console.WriteLine(GetSumOfChars(text1, text2));
        }

        public static int GetSumOfChars(string text1, string text2)
        {
            int sum = 0;
            int maxLength = Math.Max(text1.Length, text2.Length);
            for (int i = 0; i < maxLength; i++)
            {
                if (text1.Length <= i)
                {
                    sum += text2[i];
                }
                else if (text2.Length <= i)
                {
                    sum += text1[i];
                }
                else
                {
                    sum += text1[i] * text2[i];
                }
            }
            return sum;
        }
    }
}
