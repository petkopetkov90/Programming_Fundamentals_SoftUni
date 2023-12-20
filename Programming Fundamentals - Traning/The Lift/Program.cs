namespace The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peoples = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < lift.Length; i++)
            {
                if (peoples == 0)
                {
                    break;
                }
                for (int j = 0; j < 4; j++)
                {
                    if (lift[i] == 4)
                    {
                        break;
                    }
                    lift[i]++;
                    peoples--;
                    if (peoples == 0)
                    {
                        break;
                    }
                }
            }

            if (peoples == 0 && lift[^1] != 4)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            else if (peoples > 0) 
            {
                Console.WriteLine($"There isn't enough space! {peoples} people in a queue!");
            }

            Console.WriteLine(string.Join(" ", lift));
        }
    }
}
