namespace Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < totalTeams; i++)
            {
                string[] details = Console.ReadLine()
                    .Split("-")
                    .ToArray();

                string teamName = details[1];
                string teamCreator = details[0];

                if (teams.Any(team => team.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                else if (teams.Any(team => team.Creator == teamCreator))
                {
                    Console.WriteLine($"{teamCreator} cannot create another team!");
                    continue;
                }

                Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
                Team team = new Team();
                team.Name = teamName;
                team.Creator = teamCreator;
                teams.Add(team);
            }

            string command;

            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] joinCommand = command.Split("->")
                    .ToArray();

                string member = joinCommand[0];
                string teamName = joinCommand[1];

                if (teams.All(team => team.Name != teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (teams.Any(team => team.Members.Contains(member)) ||
                    teams.Any(team => team.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }

                teams[teams.FindIndex(team => team.Name == teamName)].Members.Add(member);
            }

            List<Team> teamsForDisband = teams.Where(team => team.Members.Count == 0).ToList();
            List<Team> validTeams = teams.Where(team => team.Members.Count > 0).ToList();
            validTeams = validTeams.OrderByDescending(team => team.Members.Count).ThenBy(team => team.Name).ToList();
            teamsForDisband = teamsForDisband.OrderBy(team => team.Name).ToList();
            validTeams.ForEach(team => Console.WriteLine(team));
            Console.WriteLine("Teams to disband:");
            teamsForDisband.ForEach(team => Console.WriteLine(team.Name));
        }
    }

    public class Team
    {
        public Team()
        {
            Members = new List<string>();
        }
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public override string ToString()
        {
            return $"{Name}\n" +
                $"- {Creator}\n" +
                $"{GetMembers()}";

        }

        public string GetMembers()
        {
            Members = Members.OrderBy(member => member).ToList();
            string result = string.Empty;

            for (int i = 0; i < Members.Count - 1; i++)
            {
                result += $"-- {Members[i]}\n";
            }

            result += $"-- {Members[Members.Count - 1]}";

            return result;
        }
    }
}