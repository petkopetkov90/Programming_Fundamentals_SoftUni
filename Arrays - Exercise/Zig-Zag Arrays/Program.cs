namespace Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int[] array1 = new int[lines];
            int[] array2 = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] array3 = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    array1[i] = array3[0];
                    array2[i] = array3[1];
                }
                else
                {
                    array1[i] = array3[1];
                    array2[i] = array3[0];
                }
            }

            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));
        }
    }
}