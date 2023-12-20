namespace Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split().ToArray();
            string[] array2 = Console.ReadLine().Split().ToArray();

            string output = string.Empty;

            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array1[j] == array2[i])
                    {
                        output += array2[i] + " ";
                    }
                }
            }

            Console.WriteLine(output);
        }
    }
}