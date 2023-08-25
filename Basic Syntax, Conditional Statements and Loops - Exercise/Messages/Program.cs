using System;

namespace Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string allChars = "abcdefghijklmnopqrstuvwxyz ";

            int smsLenght = int.Parse(Console.ReadLine());

            string output = string.Empty;

            for (int i = 0; i < smsLenght; i++)
            {
                string nextChar = Console.ReadLine();

                int mainDigit = int.Parse(nextChar[0].ToString()) % 10;
                int numbersOfDigit = nextChar.Length;
                int index = ((mainDigit - 2) * 3) + numbersOfDigit - 1;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    index += 1;
                }
                else if (mainDigit == 0)
                {
                    index = 26;
                }

                output += allChars[index]; ;
            }

            Console.WriteLine(output);
        }
    }
}