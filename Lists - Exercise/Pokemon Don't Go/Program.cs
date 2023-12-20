namespace Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<long> distances = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            long sum = 0;

            while (distances.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                long elementValue = 0;

                if (index < 0)
                {
                    index = 0;
                    int copy = distances.Count -1;
                    elementValue = distances[index];
                    RemoveAndCopy(distances, index, copy);
                }
                else if (index > distances.Count - 1)
                {
                    index = distances.Count - 1;
                    int copy = 0;
                    elementValue = distances[index];
                    RemoveAndCopy(distances, index, copy);
                }
                else
                {
                    elementValue = distances[index];
                    distances.RemoveAt(index);
                }

                sum += elementValue;
                IncreaseAndDecreaseElements(distances, elementValue);
            }

            Console.WriteLine(sum);
        }

        static void IncreaseAndDecreaseElements(List<long> distances, long elementValue)
        {
            for (int i = 0; i < distances.Count; i++)
            {
                if (distances[i] <= elementValue)
                {
                    distances[i] += elementValue;
                }
                else
                {
                    distances[i] -= elementValue;
                }
            }
        }

        static void RemoveAndCopy(List<long> distances, int index, int copy)
        {
            distances[index] = distances[copy];
        }

    }
}