namespace Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = "";
            while ((command = Console.ReadLine()) != "3:1")
            {
                List<string> commands = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (commands[0] == "merge")
                {
                    MergeStartIndexTillEndIndex(inputList, int.Parse(commands[1]), int.Parse(commands[2]));
                }
                else if (commands[0] == "divide")
                {
                    DivideElementAtIndex(inputList, int.Parse(commands[1]), int.Parse(commands[2]));
                }

            }

            Console.WriteLine(string.Join(" ", inputList));
        }

        static void DivideElementAtIndex(List<string> inputList, int index, int partitions)
        {
            int count = inputList[index].Length / partitions;

            char[] atIndex = inputList[index].ToCharArray();
            inputList.RemoveAt(index);

            List<char> chars = new List<char>();

            for (int i = 0; i < atIndex.Length; i++)
            {
                chars.Add(atIndex[i]);
            }

            for (int part = 1; part <= partitions; part++)
            {
                string current = "";

                if (part == partitions)
                {
                    current = string.Join("", chars);
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        current += chars[0];
                        chars.RemoveAt(0);
                    }

                }

                inputList.Insert(index, current);
                index++;
            }
        }
        static void MergeStartIndexTillEndIndex(List<string> inputList, int startIndex, int endIndex)
        {
            if (endIndex >= inputList.Count)
            {
                endIndex = inputList.Count - 1;
            }
            if (startIndex >= inputList.Count)
            {
                startIndex = inputList.Count - 1;
            }
            if (endIndex < 0)
            {
                endIndex = 0;
            }
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                inputList[startIndex] += inputList[startIndex + 1];
                inputList.RemoveAt(startIndex + 1);
            }
        }
    }
}
