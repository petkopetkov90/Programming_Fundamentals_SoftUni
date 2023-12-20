namespace Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    IntResult(int.Parse(Console.ReadLine()));
                    break;
                case "real":
                    RealResult(double.Parse(Console.ReadLine()));
                    break;
                case "string":
                    StringResult(Console.ReadLine());
                    break;
            }
        }
        static void StringResult(string text)
        {
            Console.WriteLine($"${text}$");
        }
        static void RealResult(double number)
        {
            Console.WriteLine($"{number * 1.50:f2}");
        }
        static void IntResult(int number)
        {
            Console.WriteLine(number * 2);
        }
    }
}