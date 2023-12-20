namespace NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PringNxNMatrix(number);

        }

        static void PringNxNMatrix(int number)
        {
            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}