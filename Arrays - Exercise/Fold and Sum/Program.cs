namespace Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] arrayFirstTop = new int[array.Length / 2];

            for (int i = 0; i < arrayFirstTop.Length / 2; i++)
            {
                arrayFirstTop[i] = array[array.Length / 4 - 1 - i];
            }

            for (int i = 0; i < arrayFirstTop.Length / 2; i++)
            {
                arrayFirstTop[i + arrayFirstTop.Length / 2] = array[array.Length - 1 - i];
            }

            int[] arraySecondBot = new int[array.Length / 2];

            for (int i = 0; i < array.Length / 2; i++)
            {
                arraySecondBot[i] = array[i + array.Length / 4];
            }

            int[] arraySum = new int[array.Length / 2];

            for (int i = 0; i < arraySum.Length; i++)
            {
                arraySum[i] = arrayFirstTop[i] + arraySecondBot[i];
            }

            Console.WriteLine(string.Join(" ", arraySum));
        }
    }
}