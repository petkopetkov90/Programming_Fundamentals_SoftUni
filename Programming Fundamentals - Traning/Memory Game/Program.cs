namespace Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int moves = 0;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                int[] integers = command.Split().Select(int.Parse).ToArray();
                int index1 = integers[0];
                int index2 = integers[1];
                moves++;

                if (index1 == index2 || index1 >= elements.Count || index2 >= elements.Count || index1 < 0 || index2 < 0)
                {
                    string newElements = $"-{moves}a";
                    elements.Insert(elements.Count / 2, newElements);
                    elements.Insert(elements.Count / 2, newElements);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }
                if (elements[index1] == elements[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[index1]}!");
                    elements.RemoveAt(Math.Min(index1, index2));
                    elements.RemoveAt(Math.Max(index1, index2) - 1);
                    if (elements.Count == 0)
                    {
                        Console.WriteLine($"You have won in {moves} turns!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }

            Console.WriteLine($"Sorry you lose :(");
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}

