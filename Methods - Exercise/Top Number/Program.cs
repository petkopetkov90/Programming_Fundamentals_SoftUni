namespace Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

                IsATopNumber(input);   
                
        }

        static void IsATopNumber(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                if (IsDivisibleBy8(i) && HoldOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
            
        }
        static bool IsDivisibleBy8(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum % 8 == 0;     
        }

        static bool HoldOddDigit(int number)
        {
            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

    }
}