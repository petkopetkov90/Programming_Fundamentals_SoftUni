namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToRemove = Console.ReadLine();

            string fullString = Console.ReadLine();

            while (fullString.Contains(stringToRemove))
            {
                int index = fullString.IndexOf(stringToRemove);
                fullString = fullString.Remove(index, stringToRemove.Length);
            }

            Console.WriteLine(fullString);
        }
    }
}
