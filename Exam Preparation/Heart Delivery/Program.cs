namespace Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> heartsNeeded = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();

            string command;
            int position = 0;

            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] commands = command.Split().ToArray();
                int length = int.Parse(commands[1]);
                position += length;
                if (position >= heartsNeeded.Count)
                {
                    position = 0;
                }
                Jumped(heartsNeeded, position);
            }
            Console.WriteLine($"Cupid's last position was {position}.");

            if (CheckForSuccess(heartsNeeded))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int count = HouseFailed(heartsNeeded);
                Console.WriteLine($"Cupid has failed {count} places.");
            }

        }

        static int HouseFailed(List<int> heartsNeeded)
        {
            int count = 0;

            for (int i = 0; i < heartsNeeded.Count; i++)
            {
                if (heartsNeeded[i] > 0)
                {
                    count++;
                }
            }

            return count;
        }

        static bool CheckForSuccess(List<int> heartsNeeded)
        {
            for (int i = 0; i < heartsNeeded.Count; i++)
            {
                if (heartsNeeded[i] > 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Jumped(List<int> heartsNeeded, int position)
        {
            if (heartsNeeded[position] <= 0)
            {
                Console.WriteLine($"Place {position} already had Valentine's day.");
                return;
            }
            heartsNeeded[position] -= 2;

            if (heartsNeeded[position] <= 0)
            {
                Console.WriteLine($"Place {position} has Valentine's day.");
                return;
            }
        }
    }
}