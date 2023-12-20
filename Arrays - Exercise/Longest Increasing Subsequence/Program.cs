namespace Longest_Increasing_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] solutions = new int[array.Length];
            int[] prevSolutions = new int[array.Length];

            int maxSolution = 0;
            int maxIndex = 0;

            for (int arrayCurrentIndex = 0; arrayCurrentIndex < array.Length; arrayCurrentIndex++)
            {
                int solution = 1;
                int prevSol = -1;   
                int currentNumber = array[arrayCurrentIndex];

                for (int solIndex = 0; solIndex < arrayCurrentIndex; solIndex++)
                {
                    int prevNumber = array[solIndex];
                    int prevSolution = solutions[solIndex];

                    if (prevNumber < currentNumber && solution <= prevSolution)
                    {
                        solution = prevSolution + 1;
                        prevSol = solIndex;
                    }
                }

                solutions[arrayCurrentIndex] = solution;
                prevSolutions[arrayCurrentIndex] = prevSol;
                
                if (solution > maxSolution)
                {
                    maxSolution = solution;
                    maxIndex = arrayCurrentIndex;
                }
            }

            int index = maxIndex;
            string finalSubs = string.Empty;

            while (index != -1)
            {
                finalSubs += $"{array[index]} ";
                index = prevSolutions[index];
            }

            int[] arrayResult = finalSubs.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Array.Reverse(arrayResult);

            Console.WriteLine(string.Join(" ", arrayResult));
        }
    }
}