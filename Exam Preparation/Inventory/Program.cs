namespace Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] commands = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (commands[0])
                {
                    case "Collect":
                        CollectAnItem(inventory, commands[1]);
                        break;
                    case "Drop":
                        DropAnItem(inventory, commands[1]);
                        break;
                    case "Combine Items":
                        CombineItems(inventory, commands[1]);
                        break;
                    case "Renew":
                        RenewItem(inventory, commands[1]);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", inventory));
        }

        static void RenewItem(List<string> inventory, string item)
        {
            if (inventory.Contains(item))
            {
                inventory.Remove(item);
                inventory.Add(item);
            }
        }

        static void CombineItems(List<string> inventory, string item)
        {
            string[] items = item.Split(":").ToArray();
            string oldItem = items[0];
            string newItem = items[1];
            if (inventory.Contains(oldItem))
            {
                int index = inventory.FindIndex(inventory => inventory.Contains(oldItem)) + 1;
                inventory.Insert(index, newItem);
            }
        }

        static void DropAnItem(List<string> inventory, string item)
        {
            inventory.Remove(item);
        }

        static void CollectAnItem(List<string> inventory, string item)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i] == item)
                {
                    return;
                }
            }
            inventory.Add(item);
        }
    }
}