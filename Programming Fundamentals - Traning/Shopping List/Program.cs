namespace Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!").ToList();
            string command;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] commandDetails = command.Split();
                string type = commandDetails[0];
                string item = commandDetails[1];
                switch (type)
                {
                    case "Urgent":
                        if (!groceries.Contains(item))
                        {
                            groceries.Insert(0, item);
                        }
                        break;
                    case "Unnecessary":
                        groceries.Remove(item);
                        break;
                    case "Correct":
                        string newItem = commandDetails[2];
                        if (groceries.Contains(item))
                        {
                            groceries[groceries.IndexOf(item)] = newItem;
                        }
                        break;
                    case "Rearrange":
                        if (groceries.Contains(item))
                        {
                            groceries.Remove(item);
                            groceries.Add(item);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
