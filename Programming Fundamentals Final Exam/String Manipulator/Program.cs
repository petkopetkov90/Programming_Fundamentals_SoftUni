namespace String_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];
                switch (command)
                {
                    case "Translate":
                        char currentChar = char.Parse(commands[1]);
                        char replacement = char.Parse(commands[2]);
                        text = text.Replace(currentChar, replacement);
                        Console.WriteLine(text);
                        // replace all char with replacement and print text
                        break;
                    case "Includes":
                        string substring = commands[1];
                        Console.WriteLine(text.Contains(substring));
                        //check if includes the substring and print true or false
                        break;
                    case "Start":
                        string startSubstring = commands[1];
                        Console.WriteLine(text.StartsWith(startSubstring));
                        // check if start with substring and print true or false
                        break;
                    case "Lowercase":
                        text = text.ToLower();
                        Console.WriteLine(text);
                        // make all lowercase and print text
                        break;
                    case "FindIndex":
                        char charToFind = char.Parse(commands[1]);
                        Console.WriteLine(text.LastIndexOf(charToFind));
                        // find index of char and print index
                        break;
                    case "Remove":
                        int startIndex = int.Parse(commands[1]);
                        int count = int.Parse(commands[2]);
                        text = text.Remove(startIndex, count);
                        Console.WriteLine(text);
                        // remove count from start index then print text
                        break;
                }
            }

        }

    }
}
