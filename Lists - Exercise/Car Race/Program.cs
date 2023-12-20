namespace Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> stepTimes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            float left = 0;
            float right = 0;

            for (int i = 0; i < stepTimes.Count / 2; i++)
            {
                left += stepTimes[i];
                right += stepTimes[stepTimes.Count - 1 - i];

                if (stepTimes[i] == 0)
                {
                    left *= 0.80f;
                }
                if (stepTimes[stepTimes.Count - 1 - i] == 0)
                {
                    right *= 0.80f;
                }
            }

            if (left < right)
            {
                Console.WriteLine($"The winner is left with total time: {left}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {right}");
            }

        }

    }
}