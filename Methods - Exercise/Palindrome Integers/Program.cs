namespace Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsPalindrome(input));
            }

        }

        static bool IsPalindrome(string text)
        {
            string firstPart = "";

            for (int i = 0; i < text.Length / 2; i++)
            {
                firstPart += text[i];
            }

            string secondPart = "";

            for (int i = 0; i < text.Length / 2; i++)
            {
                secondPart += text[text.Length - 1 - i];
            }

            return firstPart == secondPart;
        }
    }
}