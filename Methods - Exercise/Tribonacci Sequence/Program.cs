namespace Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] tribNumbers = new int[num];

            tribNumbers = TribonacciNumbers(tribNumbers, num);
            Console.WriteLine(string.Join(" ", tribNumbers));
        }

        static int[] TribonacciNumbers(int[] array, int number)
        {

            for (int i = 0; i < number; i++)
            {
                if (i < 2)
                {
                    array[i] = 1;
                }
                else if (i == 2)
                {
                    array[i] = array[i - 1] + array[i - 2];
                }
                else
                {
                    array[i] = array[i - 1] + array[i - 2] + array[i - 3];
                }
            }
            return array;
        }
    }
}