using System.Xml.Linq;

namespace Friend_List_Maintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input;
            int BlacklistedNames = 0;
            int lostNames = 0;
            while ((input = Console.ReadLine()) != "Report")
            {
                string[] commands = input.Split().ToArray();
                switch (commands[0])
                {
                    case "Blacklist":
                        BlacklistedNames = BlacklistName(friends, BlacklistedNames, commands[1]);
                        break;
                    case "Error":
                        lostNames = ErrorName(friends, lostNames, int.Parse(commands[1]));
                        break;
                    case "Change":
                        ChangeName(friends, commands[2], int.Parse(commands[1]));
                        break;
                }
            }
            Console.WriteLine($"Blacklisted names: {BlacklistedNames}");
            Console.WriteLine($"Lost names: {lostNames}");
            Console.WriteLine(string.Join(" ", friends));
        }

        static void ChangeName(List<string> friends, string newName, int index)
        {
            if (index >= 0 && index < friends.Count)
            {
                if (friends[index] != "Lost" && friends[index] != "Blacklisted")
                {
                    Console.WriteLine($"{friends[index]} changed his username to {newName}.");
                    friends[index] = newName;
                    return;
                }
            }
        }

        static int  ErrorName(List<string> friends, int lostNames, int index)
        {
            if (index < friends.Count && index >= 0)
            {
                if (friends[index] != "Lost" && friends[index] != "Blacklisted")
                {
                    Console.WriteLine($"{friends[index]} was lost due to an error.");
                    friends[index] = "Lost";
                    lostNames++;
                }
            }
                return lostNames;
        }

        static int BlacklistName(List<string> friends, int BlacklistedNames, string name)
        {
            if (friends.Contains(name))
            {
                int index = friends.IndexOf(name);
                friends[index] = "Blacklisted";
                Console.WriteLine($"{name} was blacklisted.");
                BlacklistedNames++;
                return BlacklistedNames;
            }
            Console.WriteLine($"{name} was not found.");
            return BlacklistedNames;
        }
    }
}