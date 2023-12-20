using System.Collections.Generic;

namespace List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                List<string> commands = command.Split().ToList();

                if (commands.Contains("Add"))
                {
                    AddNumberToEndOfList(numbers, int.Parse(commands[1]));
                }
                else if (commands.Contains("Insert"))
                {
                    InsertNumberToList(numbers, int.Parse(commands[1]), int.Parse(commands[2]));
                }
                else if (commands.Contains("Remove"))
                {
                    RemoveNumberAtIndexFromList(numbers, int.Parse(commands[1]));
                }
                else if (commands.Contains("Shift"))
                {
                    if (commands.Contains("left"))
                    {
                        FirstNumberBecomeLastInListXTimex(numbers, int.Parse(commands[2]));
                    }
                    else if (commands.Contains("right"))
                    {
                        LastNumberBecomeFirstInListXTimes(numbers, int.Parse(commands[2]));
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void LastNumberBecomeFirstInListXTimes(List<int> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(0, list.Last());
                list.RemoveAt(list.Count - 1);
            }
        }

        static void FirstNumberBecomeLastInListXTimex(List<int> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(list[0]);
                list.RemoveAt(0);
            }
        }

        static void RemoveNumberAtIndexFromList(List<int> list, int index)
        {
            if (index >= list.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            list.RemoveAt(index);
        }

        static void InsertNumberToList(List<int> list, int number, int index)
        {
            if (index >= list.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            list.Insert(index, number);
        }

        static void AddNumberToEndOfList(List<int> list, int number)
        {
            list.Add(number);
        }
    }
}