namespace Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetResult(number1, operation, number2));
        }

        static double GetResult(int number1, char operation, int number2)
        {
            double result = 0;

            switch (operation)
            {
                case '/':
                    result = number1 / number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
            }

            return result;

        }
    }
}