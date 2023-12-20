namespace World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Travel")
            {
                string[] commands = input.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commands[0];
                if (command == "Add Stop")
                {
                    int index = int.Parse(commands[1]);
                    string newStop = commands[2];
                    if (index >= 0 && index < stops.Length)
                    {
                        stops = stops.Insert(index, newStop);
                    }
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    if ((startIndex >= 0 && startIndex < stops.Length) && (endIndex >= startIndex && endIndex < stops.Length))
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                    }

                }
                else if (command == "Switch")
                {
                    string oldString = commands[1];
                    string newString = commands[2];
                    if (stops.Contains(oldString))
                    {
                        stops = stops.Replace(oldString, newString);
                    }
                }

                Console.WriteLine(stops);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
