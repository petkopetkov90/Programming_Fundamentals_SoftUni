namespace List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<string> commands = Console.ReadLine()
                .Split()
                .ToList();

            bool changes = false;

            while (commands[0] != "end")
            {
                switch (commands[0])
                {
                    case "Add":
                        AddNumberToEndOfList(numbers, int.Parse(commands[1]));
                        changes = true;
                        break;
                    case "Remove":
                        RemoveNumberFromList(numbers, int.Parse(commands[1]));
                        changes = true;
                        break;
                    case "RemoveAt":
                        RemoveAtIndexFromList(numbers, int.Parse(commands[1]));
                        changes = true;
                        break;
                    case "Insert":
                        InsertNumberAtIndextInList(numbers, int.Parse(commands[1]), int.Parse(commands[2]));
                        changes = true;
                        break;
                    case "Contains":
                        CheckIfListContainsNumber(numbers, int.Parse(commands[1]));
                        break;
                    case "PrintEven":
                        PrintEvenNumbersFromList(numbers);
                        break;
                    case "PrintOdd":
                        PrintOddNumbersFromList(numbers);
                        break;
                    case "GetSum":
                        PrintSumOfNumbersFromList(numbers);
                        break;
                    case "Filter":
                        string condition = commands[1];
                        int number = int.Parse(commands[2]);
                        PintNumbersIfTrueFromList(numbers, condition, number);
                        break;
                }

                commands = Console.ReadLine()
                .Split()
                .ToList();
            }

            if (changes)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static void PintNumbersIfTrueFromList(List<int> list, string condition, int number)
        {
            List<int> currentList = new List<int>();

            switch (condition)
            {
                case "<":
                    PrintLowerNumbers(list, number);
                    break;
                case ">":
                    PrintBiggerNumbers(list, number);
                    break;
                case "<=":
                    PrintLowerOrEqualNumbers(list, number);
                    break;
                case ">=":
                    PrintBiggerOrEqualNumbers(list, number);
                    break;
            }
        }

        private static void PrintBiggerOrEqualNumbers(List<int> list, int number)
        {
            List<int> currentList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] >= number)
                {
                    currentList.Add(list[i]);
                }
            }

            Console.WriteLine(string.Join(" ", currentList));
        }

        static void PrintLowerOrEqualNumbers(List<int> list, int number)
        {
            List<int> currentList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= number)
                {
                    currentList.Add(list[i]);
                }
            }

            Console.WriteLine(string.Join(" ", currentList));
        }

        static void PrintBiggerNumbers(List<int> list, int number)
        {
            List<int> currentList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > number)
                {
                    currentList.Add(list[i]);
                }
            }

            Console.WriteLine(string.Join(" ", currentList));
        }

        static void PrintLowerNumbers(List<int> list, int number)
        {
            List<int> currentList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < number)
                {
                    currentList.Add(list[i]);
                }
            }

            Console.WriteLine(string.Join(" ", currentList));
        }

        static void PrintSumOfNumbersFromList(List<int> list)
        {
            Console.WriteLine(list.Sum());
        }

        static void PrintOddNumbersFromList(List<int> list)
        {
            List<int> currentList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    currentList.Add(list[i]);
                }
            }
            Console.WriteLine(string.Join(" ", currentList));
        }

        static void PrintEvenNumbersFromList(List<int> list)
        {
            List<int> currentList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    currentList.Add(list[i]);
                }
            }
            Console.WriteLine(string.Join(" ", currentList));
        }

        static void CheckIfListContainsNumber(List<int> list, int number)
        {
            if (list.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        private static void InsertNumberAtIndextInList(List<int> list, int number, int index)
        {
            list.Insert(index, number);
        }
        private static void RemoveAtIndexFromList(List<int> list, int number)
        {
            list.RemoveAt(number);
        }
        private static void RemoveNumberFromList(List<int> list, int number)
        {
            list.Remove(number);
        }
        private static void AddNumberToEndOfList(List<int> list, int number)
        {
            list.Add(number);
        }
    }
}