namespace Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;

            while ((text = Console.ReadLine()) != "end")
            {
                string reversedText = string.Empty;
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reversedText += text[i];
                }

                Console.WriteLine($"{text} = {reversedText}");
            }
        }
    }
}
