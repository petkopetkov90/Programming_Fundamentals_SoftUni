namespace Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char firstChar = input[i][0];
                char secondChar = input[i][input[i].Length - 1];
                double number = double.Parse(input[i].Substring(1, (input[i].Length - 2)));

                if(char.IsUpper(firstChar))
                {
                    number = number / (firstChar - 64);
                }
                else if (char.IsLower(firstChar))
                {
                    number = number * (firstChar - 96);
                }

                if (char.IsUpper(secondChar))
                {
                    number = number - (secondChar - 64);
                }
                else if (char.IsLower(secondChar))
                {
                    number = number + (secondChar - 96);
                }
                
                totalSum += number;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
