namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());

            List<string> commands = Console.ReadLine()
                .Split()
                .ToList();

            while (commands[0] != "end")
            {
                if (commands.Count > 1)
                {
                    wagons.Add(int.Parse(commands[1]));
                }
                else
                {
                    AddToWagon(wagons, int.Parse(commands[0]), wagonCapacity);
                }

                commands = Console.ReadLine()
                .Split()
                .ToList();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }

        static void AddToWagon(List<int> wagons, int passengers, int capacity)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                if (passengers + wagons[i] <= capacity)
                {
                    wagons[i] += passengers;
                    break;
                }
            }
        }
    }
}