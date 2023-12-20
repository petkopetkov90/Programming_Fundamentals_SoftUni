namespace Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int rotate = 0; rotate < rotations; rotate++)
            {
                int lastNum = array[0];

                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }

                array[array.Length - 1] = lastNum;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}