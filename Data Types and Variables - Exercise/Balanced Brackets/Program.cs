using System;

namespace Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int openCount = 0;
            int closedCount = 0;
            string output = string.Empty;

            for (int i = 0; i < lines; i++)
            {
                string bracketsOr = Console.ReadLine();

                if (bracketsOr == "(")
                {
                    openCount++;
                }
                if (bracketsOr == ")")
                {
                    closedCount++;

                    if (openCount - closedCount != 0)
                    {
                        break;
                    }
                }
            }
            if (openCount == closedCount)
            {
                output = "BALANCED";
            }
            else
            {
                output = "UNBALANCED";
            }
            Console.WriteLine(output);
        }
    }

}