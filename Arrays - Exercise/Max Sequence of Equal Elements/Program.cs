namespace Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxSequence = 1;
            int maxNumber = int.MinValue;
            int sequence = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    sequence++;

                    if (sequence > maxSequence)
                    {
                        maxSequence = sequence;
                        maxNumber = numbers[i];
                    }
                }
                else
                {
                    sequence = 1;
                }
            }

            if (maxSequence == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                for (int i = 0; i < maxSequence; i++)
                {
                    Console.Write(maxNumber + " ");
                }
            }
        }
    }
}