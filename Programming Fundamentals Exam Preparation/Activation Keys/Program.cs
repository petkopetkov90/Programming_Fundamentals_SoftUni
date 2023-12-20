using System.Data.SqlTypes;

namespace Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] commands = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commands[0];
                switch (command)
                {
                    case "Contains":
                        string substring = commands[1];
                        if (rawKey.Contains(substring))
                        {
                            Console.WriteLine($"{rawKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        string side = commands[1];
                        int startIndex = int.Parse(commands[2]);
                        int endIndex = int.Parse(commands[3]);
                        string subPart = rawKey.Substring(startIndex, endIndex - startIndex);
                        rawKey = rawKey.Remove(startIndex, endIndex - startIndex);

                        if (side == "Upper")
                        {
                            rawKey = rawKey.Insert(startIndex, subPart.ToUpper());
                        }
                        else
                        {
                            rawKey = rawKey.Insert(startIndex, subPart.ToLower());
                        }

                        Console.WriteLine(rawKey);
                        break;
                    case "Slice":
                        int startCut = int.Parse(commands[1]);
                        int endCut = int.Parse(commands[2]);
                        rawKey = rawKey.Remove(startCut, endCut-startCut);
                        Console.WriteLine(rawKey);
                        break;
                }
            }
            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
