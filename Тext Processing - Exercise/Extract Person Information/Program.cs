namespace Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string text = Console.ReadLine();
                int startIndex = text.IndexOf('@') + 1;
                int length = text.IndexOf('|') - startIndex;
                if (startIndex == 0 || length < 1)
                {
                    continue;
                }
                string name = text.Substring(startIndex, length);

                startIndex = text.IndexOf('#') + 1;
                length = text.IndexOf('*') - startIndex;
                if (startIndex == 0 || length < 1)
                {
                    continue;
                }
                string age = text.Substring(startIndex, length);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
