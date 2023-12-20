namespace MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Player> playerPool = new Dictionary<string, Player>();
            string input;
            while ((input = Console.ReadLine()) != "Season end")
            {
                if (!input.Contains("vs"))
                {
                    string[] commands = input.Split(" -> ");
                    string playerName = commands[0];
                    string playerPosition = commands[1];
                    int playerSkill = int.Parse(commands[2]);
                    Player player = new Player(playerName);

                    if (!playerPool.ContainsKey(playerName))
                    {
                        playerPool.Add(playerName, player);
                    }
                    if (!playerPool[playerName].PositionSkill.ContainsKey(playerPosition))
                    {
                        playerPool[playerName].PositionSkill.Add(playerPosition, playerSkill);
                    }
                    if (playerPool[playerName].PositionSkill[playerPosition] < playerSkill)
                    {
                        playerPool[playerName].PositionSkill[playerPosition] = playerSkill;
                    }

                }
                else
                {
                    string[] commands = input.Split(" vs ");
                    string player1 = commands[0];
                    string player2 = commands[1];

                    if (playerPool.ContainsKey(player1) && playerPool.ContainsKey(player2))
                    {
                        string playerToRemove = "";
                        foreach (var position1 in playerPool[player1].PositionSkill)
                        {
                            foreach (var position2 in playerPool[player2].PositionSkill)
                            {
                                if (position1.Key == position2.Key)
                                {
                                    if (playerPool[player1].PositionSkill.Values.Sum() > playerPool[player2].PositionSkill.Values.Sum())
                                    {
                                        playerToRemove = player2;
                                    }
                                    else
                                    {
                                        playerToRemove = player1;
                                    }
                                }
                            }
                        }
                        playerPool.Remove(playerToRemove);
                    }
                }
            }

            foreach (Player player in playerPool.Values)
            {
                player.GetTotalSkill();
            }

            foreach (Player? player in playerPool.Values.OrderByDescending(x => x.TotalSkill).ThenBy(x => x.Name))
            {
                Console.WriteLine(player);
            }
        }
    }
    public class Player
    {
        public Player(string name)
        {
            Name = name;
            PositionSkill = new Dictionary<string, int>();
        }

        public string Name { get; set; }
        public Dictionary<string, int> PositionSkill { get; set; }
        public int TotalSkill { get; set; }
        public void GetTotalSkill()
        {
            TotalSkill = 0;
            foreach (KeyValuePair<string, int> skillPoints in PositionSkill)
            {
                TotalSkill += skillPoints.Value;
            }
        }

        public override string ToString()
        {
            string output = string.Empty;
            output += $"{Name}: {TotalSkill} skill";
            foreach (KeyValuePair<string, int> positionSkill in PositionSkill.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                output += $"\n- {positionSkill.Key} <::> {positionSkill.Value}";
            }
            return output;
        }
    }
}