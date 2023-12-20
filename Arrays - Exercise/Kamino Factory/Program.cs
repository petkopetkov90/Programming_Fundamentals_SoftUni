namespace Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] bestArray = new int[length];
            int bestStartIndex = length;
            int bestSequence = 0;
            int bestSum = 0;
            int bestSample = 1;

            string input = Console.ReadLine();

            int currentSample = 0;

            while (input != "Clone them!")
            {
                int[] currentArray = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                currentSample++;

                int currentSum = 0;
                int startIndex = length;
                int sequence = 0;
                int currentSequence = 0;

                for (int i = 0; i < length; i++)
                {
                    currentSum += currentArray[i];

                    if (currentArray[i] == 1)
                    {
                        currentSequence++;

                        if (sequence < currentSequence)
                        {
                            sequence = currentSequence;
                            startIndex = i + 1 - currentSequence;
                        }
                    }
                    else
                    {
                        currentSequence = 0;
                    }
                }

                if (sequence > bestSequence)
                {
                    bestSequence = sequence;
                    bestArray = currentArray;
                    bestStartIndex = startIndex;
                    bestSum = currentSum;
                    bestSample = currentSample;
                }
                else if (sequence == bestSequence)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestStartIndex = startIndex;
                        bestArray = currentArray;
                        bestSum = currentSum;
                        bestSample = currentSample;
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (currentSum > bestSum)
                        {
                            bestSum = currentSum;
                            bestArray = currentArray;
                            bestSample = currentSample;
                        }
                    }
                }

                input = Console.ReadLine();

            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestArray));
        }
    }
}
