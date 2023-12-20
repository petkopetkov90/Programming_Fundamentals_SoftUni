using System.Text;

namespace Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfString = Console.ReadLine().Split();

            StringBuilder stringConcatBuilder = new StringBuilder();

            for (int i = 0; i < arrayOfString.Length; i++)
            {
                for (int j = 0; j < arrayOfString[i].Length; j++)
                {
                    stringConcatBuilder.Append(arrayOfString[i]);
                }
            }

            Console.WriteLine(stringConcatBuilder.ToString());
        }
    }
}
