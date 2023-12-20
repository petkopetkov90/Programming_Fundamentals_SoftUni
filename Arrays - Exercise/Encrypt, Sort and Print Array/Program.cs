namespace Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] sums = new int[number];
            char[] vowels = new char[10] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int stringsToEnter = 0; stringsToEnter < number; stringsToEnter++)
            {
                string input = Console.ReadLine();

                int sum = 0;
                int codeOfChar = 0;

                for (int inputChar = 0; inputChar < input.Length; inputChar++)
                {
                    bool isVowel = false;

                    for (int i = 0; i < vowels.Length; i++)
                    {
                        if (input[inputChar] == vowels[i])
                        {
                            isVowel = true;
                            break;
                        }
                    }

                    if (isVowel)
                    {
                        sum += (int)input[inputChar] * input.Length;
                    }
                    else
                    {
                        sum += (int)input[inputChar] / input.Length;
                    }

                }
                sums[stringsToEnter] = sum;
            }

            Array.Sort(sums);

            for (int i = 0; i < sums.Length; i++)
            {
                Console.WriteLine(sums[i]);
            }
        }
    }
}