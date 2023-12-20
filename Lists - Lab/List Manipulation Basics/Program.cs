namespace List_Manipulation_Basics
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

            while (commands[0] != "end")
            {
                switch (commands[0])
                {
                    case "Add":
                        AddNumberToEndOfList(numbers, int.Parse(commands[1]));
                        break;
                    case "Remove":
                        RemoveNumberFromList(numbers, int.Parse(commands[1]));
                        break;
                    case "RemoveAt":
                        RemoveAtIndexFromList(numbers, int.Parse(commands[1]));
                        break;
                    case "Insert":
                        InsertNumberAtIndextInList(numbers, int.Parse(commands[1]), int.Parse(commands[2]));
                        break;
                }
                commands = Console.ReadLine()
                .Split()
                .ToList();
            }

            Console.WriteLine(string.Join(" ", numbers));
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