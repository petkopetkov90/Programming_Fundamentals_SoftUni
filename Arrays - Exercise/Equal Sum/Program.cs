namespace Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (array.Length == 1)
            {
                Console.WriteLine(0);
            }
            else if (array.Length > 1)
            {
                bool isNotEqual = true;

                for (int i = 0; i < array.Length; i++)
                {
                    int leftSum = 0;
                    int rightSum = 0;

                    for (int leftI = i - 1; leftI >= 0; leftI--)
                    {
                        leftSum += array[leftI];
                    }

                    for (int rightI = i + 1; rightI < array.Length; rightI++)
                    {
                        rightSum += array[rightI];
                    }

                    if (leftSum == rightSum)
                    {
                        Console.WriteLine(i);
                        isNotEqual = false;
                        break;
                    }
                }
                if (isNotEqual)
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}