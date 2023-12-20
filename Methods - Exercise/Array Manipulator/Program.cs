namespace Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string[] commands = Console.ReadLine()
                .Split()
                .ToArray();

            while (commands[0] != "end")
            {
                if (commands[0] == "exchange")
                {
                    int index = int.Parse(commands[1]);
                    array = ExchangeArray(array, index);
                }
                else if (commands[0] == "max")
                {
                    PrintMaxNumIndex(array, commands[1]);
                }
                else if (commands[0] == "min")
                {
                    PrintMinNumIndex(array, commands[1]);
                }
                else if (commands[0] == "first")
                {
                    int count = int.Parse(commands[1]);
                    PrintFirstX(array, count, commands[2]);
                }
                else if (commands[0] == "last")
                {
                    int count = int.Parse(commands[1]);
                    PrintLastX(array, count, commands[2]);
                }

                commands = Console.ReadLine()
                .Split()
                .ToArray();
            }
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }

        static int[] ExchangeArray(int[] array, int index)
        {
            if (index < 0 || index > array.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return array;
            }

            int[] NewArray = new int[array.Length];

            for (int i = 0; i < array.Length - (index + 1); i++)
            {
                NewArray[i] = array[i + (index + 1)];
            }

            for (int i = 0; i < index + 1; i++)
            {
                NewArray[array.Length - index - 1 + i] = array[i];
            }

            return NewArray;
        }
        static void PrintMaxNumIndex(int[] array, string evenOrOdd)
        {
            int maxNumber = int.MinValue;
            int maxIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (evenOrOdd == "odd" && array[i] % 2 != 0)
                {
                    if (maxNumber <= array[i])
                    {
                        maxNumber = array[i];
                        maxIndex = i;
                    }
                }
                else if (evenOrOdd == "even" && array[i] % 2 == 0)
                {
                    if (maxNumber <= array[i])
                    {
                        maxNumber = array[i];
                        maxIndex = i;
                    }
                }
            }

            if (maxIndex != -1)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static void PrintMinNumIndex(int[] array, string evenOrOdd)
        {
            int minNumber = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (evenOrOdd == "odd" && array[i] % 2 != 0)
                {
                    if (minNumber >= array[i])
                    {
                        minNumber = array[i];
                        minIndex = i;
                    }
                }
                else if (evenOrOdd == "even" && array[i] % 2 == 0)
                {
                    if (minNumber >= array[i])
                    {
                        minNumber = array[i];
                        minIndex = i;
                    }
                }
            }

            if (minIndex != -1)
            {
                Console.WriteLine(minIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static void PrintFirstX(int[] array, int count, string evenOrOdd)
        {

            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int currentCount = 0;
            string output = "";

            for (int i = 0; i < array.Length; i++)
            {
                if ((evenOrOdd == "odd") && array[i] % 2 != 0)
                {
                    currentCount++;
                    output += array[i] + " ";

                    if (currentCount == count)
                    {
                        break;
                    }
                }
                else if ((evenOrOdd == "even") && array[i] % 2 == 0)
                {
                    currentCount++;
                    output += array[i] + " ";

                    if (currentCount == count)
                    {
                        break;
                    }
                }
            }

            Console.Write("[");
            if (currentCount != 0)
            {
                int[] numbers = output.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                Console.Write(string.Join(", ", numbers));
            }
            Console.WriteLine("]");
        }
        private static void PrintLastX(int[] array, int count, string evenOrOdd)
        {

            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int currentCount = 0;
            string output = "";

            for (int i = 0; i < array.Length; i++)
            {
                if ((evenOrOdd == "odd") && array[array.Length - 1 - i] % 2 != 0)
                {
                    currentCount++;
                    output += array[array.Length - 1 - i] + " ";

                    if (currentCount == count)
                    {
                        break;
                    }
                }
                else if ((evenOrOdd == "even") && array[array.Length - 1 - i] % 2 == 0)
                {
                    currentCount++;
                    output += array[array.Length - 1 - i] + " ";

                    if (currentCount == count)
                    {
                        break;
                    }
                }
            }

            Console.Write("[");
            if (currentCount != 0)
            {
                int[] numbers = output.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                Array.Reverse(numbers);
                Console.Write(string.Join(", ", numbers));
            }
            Console.WriteLine("]");
        }
    }
}