using System.Security.Cryptography;

namespace Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            switch (type)
            {
                case "string":
                    GetMax(input1, input2);
                    break;
                case "int":
                    int number1 = int.Parse(input1);
                    int number2 = int.Parse(input2);
                    GetMax(number1, number2);
                    break;
                case "char":
                    char char1 = char.Parse(input1);
                    char char2 = char.Parse(input2);
                    GetMax(char1, char2);
                    break;
            }
        }

        static void GetMax(string input1, string input2)
        {
            if (string.Compare(input1, input2, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine(input1);
            }
            else
            {
                Console.WriteLine(input2);
            }
        }

        static void GetMax(int number1, int number2)
        {
            if (number1 >= number2)
            {
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number2);
            }
        }
        static void GetMax(char char1, char char2)
        {
            if (char1 >= char2)
            {
                Console.WriteLine(char1);
            }
            else
            {
                Console.WriteLine(char2);
            }
        }
    }
}