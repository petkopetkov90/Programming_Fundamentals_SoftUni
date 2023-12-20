namespace Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); // number >= 1 && <=60

            int[] array = new int[number];

            for (int row = 0; row < number; row++)
            {
                int[] currentArray = new int[row + 1];

                currentArray[0] = 1;

                for (int col = 1; col <= row; col++)
                {
                    currentArray[col] = (array[col] + array[col - 1]);

                }

                for (int i = 0; i < currentArray.Length; i++)
                {
                    array[i] = currentArray[i];
                }

                Console.WriteLine(string.Join(" ", currentArray));
            }
        }
    }
}