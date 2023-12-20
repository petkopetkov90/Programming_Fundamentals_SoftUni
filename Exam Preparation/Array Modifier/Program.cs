using System.Globalization;

namespace Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;

            while((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split().ToArray();
                
                switch (commands[0])
                {
                    case "swap":
                        SwapElements(integers, int.Parse(commands[1]), int.Parse(commands[2]));
                        break;
                    case "multiply":
                        MultiplyElements(integers, int.Parse(commands[1]), int.Parse(commands[2]));
                        break;
                    case "decrease":
                        DecreaseElements(integers);
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", integers));
        }

        static void DecreaseElements(List<int> integers)
        {
            for (int i = 0; i < integers.Count; i++)
            {
                integers[i] -= 1;
            }
        }

        static void MultiplyElements(List<int> integers, int index1, int index2)
        {
            integers[index1] *= integers[index2];
        }

        static void SwapElements(List<int> integers, int index1, int index2)
        {
            int temp = integers[index1];
            integers[index1] = integers[index2];
            integers[index2] = temp;
        }
    }
}