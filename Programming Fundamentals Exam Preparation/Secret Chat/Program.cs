using System.Text;

namespace Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] commands = input.Split(":|:",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commands[0];
                switch (command)
                {
                    case "InsertSpace":
                        int index = int.Parse(commands[1]);
                        message = message.Insert(index, " ");
                        Console.WriteLine(message);
                        break;
                    case "Reverse":
                        string subText = commands[1];
                        if (!message.Contains(subText))
                        {
                            Console.WriteLine("error");
                            continue;
                        }
                        int i = message.IndexOf(subText);
                        message = message.Remove(i, subText.Length);
                        message += ReversedSubtext(subText);
                        Console.WriteLine(message);
                        break;
                    case "ChangeAll":
                        string subPart = commands[1];
                        string replacements = commands[2];
                        message = message.Replace(subPart, replacements);
                        Console.WriteLine(message);
                        break;
                }

            }
            Console.WriteLine($"You have a new text message: {message}");
        }

        private static string ReversedSubtext(string subText)
        {
            StringBuilder subBuilder = new StringBuilder();
            for (int i = subText.Length - 1; i >= 0; i--)
            {
                subBuilder.Append(subText[i]);
            }
            return subBuilder.ToString();
        }
    }
}
