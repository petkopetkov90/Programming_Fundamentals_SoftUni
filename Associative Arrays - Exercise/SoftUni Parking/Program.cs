namespace SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            Dictionary<string,string> namesAndPlates = new Dictionary<string,string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] commands = Console.ReadLine().Split();

                if (commands[0] == "register")
                {
                    string username = commands[1];   
                    string licensePlate = commands[2];

                    if (namesAndPlates.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {namesAndPlates[username]}");
                        continue;
                    }

                    namesAndPlates.Add(username, licensePlate);
                    Console.WriteLine($"{username} registered {licensePlate} successfully");

                }
                else if (commands[0] == "unregister")
                {
                    string username = commands[1];

                    if (!namesAndPlates.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                        continue;
                    }

                    namesAndPlates.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                }
            }

            foreach (KeyValuePair<string, string> user in namesAndPlates)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}