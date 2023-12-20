
namespace Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Contest> contests = new Dictionary<string, Contest>();
            SortedDictionary<string, User> users = new SortedDictionary<string, User>();
            
            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] data = input.Split(":");
                string contestName = data[0];
                string contestPassword = data[1];

                if (!contests.ContainsKey(contestName))
                {
                    Contest contest = new Contest(contestName, contestPassword);
                    contests.Add(contestName, contest);
                }
            }

            string nextInput;
            while ((nextInput = Console.ReadLine()) != "end of submissions")
            {
                string[] data = nextInput.Split("=>");
                string contestName = data[0];
                string contestPassword = data[1];
                string userName = data[2];
                int userPoints = int.Parse(data[3]);

                if (contests.ContainsKey(contestName) && contestPassword == contests[contestName].Password)
                {
                    if (!users.ContainsKey(userName))
                    {
                        User user = new User(userName);
                        users.Add(userName, user);
                    }

                    if (!users[userName].Contest.ContainsKey(contestName))
                    {
                        users[userName].Contest.Add(contestName, userPoints);
                    }

                    if (users[userName].Contest[contestName] < userPoints)
                    {
                        users[userName].Contest[contestName] = userPoints;
                    }
                }
            }
            int bestPoints = int.MinValue;
            string bestUser = string.Empty;

            foreach (var user in users)
            {
                if (user.Value.Contest.Values.Sum() > bestPoints)
                {
                    bestPoints = user.Value.Contest.Values.Sum();
                    bestUser = user.Value.Name;
                }
            }
            Console.WriteLine($"Best candidate is {bestUser} with total {bestPoints} points.");
            Console.WriteLine("Ranking: ");
            foreach (KeyValuePair<string, User> user in users)
            {
                Console.WriteLine(user.Value);
            }
        }

    }
    public class Contest
    {
        public Contest(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public string Name { get; set; }
        public string Password { get; set; }
    }

    public class User
    {
        public User(string name)
        {
            Name = name;
            Contest = new Dictionary<string, int>();
        }

        public Dictionary<string, int> Contest { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            string output = "";
            output += $"{Name}";
            foreach (KeyValuePair<string, int> contestPair in Contest.OrderByDescending(key => key.Value))
            {
                output += $"\n#  {contestPair.Key} -> {contestPair.Value}";
            }
            return output;
        }

    }
}