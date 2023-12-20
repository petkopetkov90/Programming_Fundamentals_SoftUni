namespace Recursive_Fibonacci
{
    internal class Program
    {
        public static int GetFibonacci(int number)
        {
            int result;

            if (momorizedFib.ContainsKey(number))
            {
                result = momorizedFib[number];
            }
            else
            {
                result = GetFibonacci(number - 1) + GetFibonacci(number - 2);
                momorizedFib[number] = result;
            }

            return result;
        }

        public static Dictionary<int, int> momorizedFib = new Dictionary<int, int>()
        {
            {1, 1},
            {2, 1}
        };

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(number));
        }

    }
}