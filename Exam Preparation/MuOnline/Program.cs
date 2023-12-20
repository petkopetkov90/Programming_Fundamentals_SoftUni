namespace MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            string[] input = Console.ReadLine()
                .Split("|")
                .ToArray();

            bool win = true;
            for (int i = 0; i < input.Length; i++)
            {
                string[] rooms = input[i].Split().ToArray();

                if (rooms[0] == "potion")
                {
                    health = YouAreHealed(health, int.Parse(rooms[1]));
                    continue;
                }
                else if (rooms[0] == "chest")
                {
                    bitcoins += int.Parse(rooms[1]);
                    Console.WriteLine($"You found {rooms[1]} bitcoins.");
                    continue;
                }
                else
                {
                    health = YouFightAMonster(rooms[0], int.Parse(rooms[1]), health);
                    if (health <= 0)
                    {
                        win = false;
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                }
            }
            if (win)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }

        static int YouFightAMonster(string monsterName, int monsterAttack, int currentHealth)
        {
            currentHealth -= monsterAttack;
            if (currentHealth <= 0)
            {
                Console.WriteLine($"You died! Killed by {monsterName}.");
                return currentHealth;
            }

            Console.WriteLine($"You slayed {monsterName}.");
            return currentHealth;
        }

        static int YouAreHealed(int CurrentHealth, int healedAmount)
        {
            int health = CurrentHealth + healedAmount;
            if (health > 100)
            {
                healedAmount = 100 - CurrentHealth;
                health = 100;
            }
            Console.WriteLine($"You healed for {healedAmount} hp.");
            Console.WriteLine($"Current health: {health} hp.");
            return health;
        }
    }
}