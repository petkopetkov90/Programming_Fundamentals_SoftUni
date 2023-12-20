namespace Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split();
                string command = commands[0];
                int index = int.Parse(commands[1]);

                if (command == "Shoot")
                {
                    int power = int.Parse(commands[2]);
                    ShootTarget(targets, index, power);
                }
                else if (command == "Add")
                {
                    int value = int.Parse(commands[2]);
                    AddTarget(targets, index, value);
                }
                else if (command == "Strike")
                {
                    int radius = int.Parse(commands[2]);
                    StikeTargets(targets, index, radius);
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }

        private static void StikeTargets(List<int> targets, int index, int radius)
        {
            if (index - radius >= 0 && index + radius < targets.Count)
            {
                int tagetsToStike = radius * 2 + 1;
                targets.RemoveRange(index - radius, tagetsToStike);
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }
        }

        private static void AddTarget(List<int> targets, int index, int value)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }

        private static void ShootTarget(List<int> targets, int index, int power)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets[index] -= power;
                if (targets[index] < 1)
                {
                    targets.RemoveAt(index);
                }
            }
        }
    }
}
