namespace Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Contest> contests = new Dictionary<string, Contest>();
            Dictionary<string, User> users = new Dictionary<string, User>();
            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] commands = input.Split(" -> ");
                string userName = commands[0];
                string contestName = commands[1];
                int userPoints = int.Parse(commands[2]);

                Contest contest = new Contest(contestName);
                User user = new User(userName);
                if (!contests.ContainsKey(contestName))
                {
                    contests.Add(contestName, contest);
                }
                if (!contests[contestName].UsersPoints.ContainsKey(userName))
                {
                    contests[contestName].UsersPoints.Add(userName, userPoints);
                }
                if (contests[contestName].UsersPoints[userName] < userPoints)
                {
                    contests[contestName].UsersPoints[userName] = userPoints;
                }
                if (!users.ContainsKey(userName))
                {
                    users.Add(userName, user);
                }
                if (!users[userName].ContestPoints.ContainsKey(contestName))
                {
                    users[userName].ContestPoints.Add(contestName, userPoints);
                }
                if (users[userName].ContestPoints[contestName] < userPoints)
                {
                    users[userName].ContestPoints[contestName] = userPoints;
                }

            }

            Console.WriteLine(string.Join("\n", contests.Values));
            Console.Write("Individual standings:");

            foreach (var user in users)
            {
                user.Value.GetTotalPoints();
            }

            string output = string.Empty;
            int count = 1;
            foreach (var user in users.Values.OrderByDescending(user => user.TotalPoints).ThenBy(user => user.Name))
            {
                output += $"\n{count}. {user.Name} -> {user.TotalPoints}";
                count++;
            }

            Console.WriteLine(output);
        }
    }

    public class User
    {
        public User(string name)
        {
            Name = name;
            ContestPoints = new Dictionary<string, int>();
        }
        public string Name { get; set; }
        public Dictionary<string, int> ContestPoints { get; set; }
        public int TotalPoints { get; set; }
        public void GetTotalPoints()
        {

            int points = 0;
            foreach (var contest in ContestPoints)
            {
                points += contest.Value;
            }
            TotalPoints = points;
        }
    }
    public class Contest
    {
        public Contest(string name)
        {
            Name = name;
            UsersPoints = new Dictionary<string, int>();
        }
        public string Name { get; set; }
        public Dictionary<string, int> UsersPoints { get; set; }
        public override string ToString()
        {
            string output = string.Empty;
            output += $"{Name}: {UsersPoints.Count} participants";
            int count = 1;
            foreach (var user in UsersPoints.OrderByDescending(user => user.Value).ThenBy(user => user.Key))
            {
                output += $"\n{count}. {user.Key} <::> {user.Value}";
                count++;
            }
            return output;
        }
    }
}