namespace Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            int listLenght = numbers.Count;
            for (int i = 0; i < listLenght / 2; i++)
            {
                numbers[i] += numbers[listLenght - 1 - i];
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}