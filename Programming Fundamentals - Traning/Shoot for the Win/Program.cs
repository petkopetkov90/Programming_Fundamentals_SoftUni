namespace Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int shotTargetsCount = 0;
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                int index = int.Parse(command);

                if (index < 0 || index >= targets.Length || targets[index] == -1)
                {
                    continue;
                }

                int targetValue = targets[index];
                targets[index] = -1;
                shotTargetsCount++;

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] != -1)
                    {
                        if (targets[i] > targetValue)
                        {
                            targets[i] -= targetValue;
                        }
                        else
                        {
                            targets[i] += targetValue;
                        }
                    }
                }
            }

            Console.WriteLine($"Shot targets: {shotTargetsCount} -> " + string.Join(" ", targets));
        }
    }
}
