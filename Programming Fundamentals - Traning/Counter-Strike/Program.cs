namespace Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int battlesWon = 0;
            string distanceInput;
            while ((distanceInput = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(distanceInput);
                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesWon} won battles and {energy} energy");
                    return;
                }
                energy -= distance;
                battlesWon++;
                if (battlesWon % 3 == 0)
                {
                    energy += battlesWon;
                }
            }

            Console.WriteLine($"Won battles: {battlesWon}. Energy left: {energy}");
        }
    }
}
