namespace Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isGreater = false;

            string output = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    isGreater = true;
                }

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        isGreater = true;
                    }
                    else
                    {
                        isGreater = false;
                        break;
                    }
                }

                if (isGreater)
                {
                    Console.Write(numbers[i] +" ");
                }
            }
        }
    }
}