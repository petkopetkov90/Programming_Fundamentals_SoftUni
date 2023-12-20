namespace Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (numbers.Contains(bomb[0]))
            {
                DetonateBombWithPower(numbers, bomb[0], bomb[1]);
            }

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }

        static void DetonateBombWithPower(List<int> list, int bomb, int power)
        {
            int bombIndex = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == bomb)
                {
                    bombIndex = i;
                }
            }

            for (int i = 0; i < power; i++)
            {
                if (bombIndex + 1 < list.Count)
                {
                    list.RemoveAt(bombIndex + 1);
                }
                if (bombIndex > 0)
                {
                    list.RemoveAt(bombIndex - 1);
                    bombIndex--;
                }
            }

            list.RemoveAt(bombIndex);
        }
    }
}