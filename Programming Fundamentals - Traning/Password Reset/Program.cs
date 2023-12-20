using System.Text;

namespace Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] commandDetails = command.Split();
                string type = commandDetails[0];
                if (type == "TakeOdd")
                {
                    password = TakeOddChars(password.ToCharArray());
                }
                else if (type == "Cut")
                {
                    int index = int.Parse(commandDetails[1]);
                    int length = int.Parse(commandDetails[2]);
                    password = CutSubtring(password, index, length);
                }
                else if (type == "Substitute")
                {
                    string substring = commandDetails[1];
                    string substitute = commandDetails[2];
                    if (password.Contains(substring))
                    {
                        password = SubstituteSubstring(password, substring, substitute);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                        continue;
                    }
                }

                Console.WriteLine(password);
            }

            Console.WriteLine($"Your password is: {password}");
        }

        private static string SubstituteSubstring(string password, string substring, string substitute)
        {
            return password.Replace(substring, substitute);
        }

        private static string CutSubtring(string password, int index, int length)
        {
            string substring = password.Substring(index, length);
            int indexOfSub = password.IndexOf(substring);
            return password.Remove(indexOfSub, substring.Length);
        }

        private static string TakeOddChars(char[] password)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < password.Length; i++)
            {
                if (i % 2 == 1)
                {
                    stringBuilder.Append(password[i]);
                }
            }
            return stringBuilder.ToString();
        }
    }
}
