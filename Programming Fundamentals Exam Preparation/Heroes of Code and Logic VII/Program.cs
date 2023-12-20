



namespace Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroDetails = Console.ReadLine().Split();
                string heroName = heroDetails[0];
                int health = int.Parse(heroDetails[1]);
                int mana = int.Parse(heroDetails[2]);
                if (health > 100)
                {
                    health = 100;
                }
                if (mana > 200)
                {
                    mana = 200;
                }
                Hero hero = new Hero(heroName, health, mana);
                heroes.Add(heroName, hero);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split(" - ").ToArray();
                string action = commands[0];
                string heroName = commands[1];
                switch (action)
                {
                    case "CastSpell":
                        int manaNeed = int.Parse(commands[2]);
                        string spellName = commands[3];
                        CastSpell(heroes,heroName,manaNeed,spellName);
                        break;
                    case "TakeDamage":
                        int damage = int.Parse(commands[2]);
                        string attacker = commands[3];
                        TakeDamage(heroes,heroName,damage,attacker);
                        break;
                    case "Recharge":
                        int manaAmount = int.Parse(commands[2]);
                        Recharge(heroes, heroName, manaAmount);
                        break;
                    case "Heal":
                        int healtAmount = int.Parse(commands[2]);
                        Heal(heroes, heroName, healtAmount);    
                        break;
                }
            }

            foreach (KeyValuePair<string, Hero> hero in heroes)
            {
                Console.WriteLine(hero.Value);
            }
        }

        public static void Heal(Dictionary<string, Hero> heroes, string heroName, int healtAmount)
        {
            int amountRecovered = 100 - heroes[heroName].Health;
            heroes[heroName].Health += healtAmount;
            if (heroes[heroName].Health > 100)
            {
                heroes[heroName].Health = 100;
            }
            else
            {
                amountRecovered = healtAmount;
            }
            Console.WriteLine($"{heroName} healed for {amountRecovered} HP!");
        }

        public static void Recharge(Dictionary<string, Hero> heroes, string heroName, int manaAmount)
        {
            int amountRecovered = 200 - heroes[heroName].Mana;
            heroes[heroName].Mana += manaAmount;
            if (heroes[heroName].Mana > 200)
            {
                heroes[heroName].Mana = 200;
            }
            else
            {
                amountRecovered = manaAmount;
            }
            Console.WriteLine($"{heroName} recharged for {amountRecovered} MP!");
        }

        public static void TakeDamage(Dictionary<string, Hero> heroes, string heroName, int damage, string attacker)
        {
            heroes[heroName].Health -= damage;
            if (heroes[heroName].Health > 0)
            {
                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].Health} HP left!");
            }
            else
            {
                Console.WriteLine($"{heroName} has been killed by {attacker}!");
                heroes.Remove(heroName);
            }
        }

        public static void CastSpell(Dictionary<string, Hero> heroes, string heroName, int manaNeed, string spellName)
        {
            if (heroes[heroName].Mana >= manaNeed)
            {
                heroes[heroName].Mana -= manaNeed;
                Console.WriteLine($"{heroes[heroName].Name} has successfully cast {spellName} and now has {heroes[heroName].Mana} MP!");
            }
            else
            {
                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            }
        }
    }

    class Hero
    {
        public Hero(string name, int health, int mana)
        {
            Name = name;
            Health = health;
            Mana = mana;
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public override string ToString()
        {
            string output = string.Empty;
            output += $"{Name}";
            output += $"\n  HP: {Health}";
            output += $"\n  MP: {Mana}";
            return output;
        }
    }
}
