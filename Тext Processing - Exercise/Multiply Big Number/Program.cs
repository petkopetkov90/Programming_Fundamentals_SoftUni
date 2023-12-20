using System.Text;

namespace Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int singleNumber = int.Parse(Console.ReadLine());

            string[] resutlArray = new string[bigNumber.Length + 1];
            int onMind = 0;
            if (bigNumber == "0" || singleNumber == 0)
            {
                Console.WriteLine("0");
                return;
            }
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int number = int.Parse(bigNumber[i].ToString());
                int result = number * singleNumber;
                if (onMind != 0)
                {
                    result += onMind;
                    onMind = 0;
                }
                if (result > 9)
                {
                    onMind = result / 10;
                    result = result % 10;
                }

                resutlArray[i + 1] = $"{result}";
            }

            if (onMind != 0)
            {
                resutlArray[0] = $"{onMind}";
                Console.WriteLine(string.Join("", resutlArray));
            }
            else
            {
                for (int i = 1; i < resutlArray.Length; i++)
                {
                    Console.Write(resutlArray[i]);
                }
            }
        }
    }
}
