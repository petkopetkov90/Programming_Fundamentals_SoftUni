namespace House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCommands = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < totalCommands; i++)
            {
                List<string> commands = Console.ReadLine()
                    .Split()
                    .ToList();

                if (commands.Count == 3)
                {
                    AddPersonToList(guests, commands[0]);
                }
                else
                {
                    RemovePersonFromList(guests, commands[0]);
                }
            }

            Console.WriteLine(string.Join("\n", guests));

        }

        static void RemovePersonFromList(List<string> guests, string name)
        {
            for (int i = 0; i < guests.Count; i++)
            {
                if (guests[i] == name)
                {
                    guests.Remove(name);
                    return;
                }
            }
            Console.WriteLine($"{name} is not in the list!");
        }

        static void AddPersonToList(List<string> guests, string name)
        {
            for (int i = 0; i < guests.Count; i++)
            {
                if (guests[i] == name)
                {
                    Console.WriteLine($"{name} is already in the list!");
                    return;
                }
            }
            guests.Add(name);
        }
    }
}