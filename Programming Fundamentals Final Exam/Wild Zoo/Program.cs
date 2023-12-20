namespace Wild_Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string input;
            while ((input = Console.ReadLine()) != "EndDay")
            {
                string[] commands = input.Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commands[0];
                string[] details = commands[1].Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command == "Add")
                {
                    string animalName = details[0];
                    int foodNeed = int.Parse(details[1]);
                    string area = details[2];
                    if (!animals.Any(x => x.Name == animalName))
                    {
                        Animal animal = new Animal(animalName, area);
                        animals.Add(animal);
                    }

                    animals.First(x => x.Name == animalName).DailyFoodNeed += foodNeed;
                }
                else if (command == "Feed")
                {
                    string animalName = details[0];
                    int foodGet = int.Parse(details[1]);

                    Animal currentAnimal = animals.FirstOrDefault(x => x.Name == animalName);

                    if (currentAnimal != null)
                    {
                        currentAnimal.DailyFoodNeed -= foodGet;

                        if (currentAnimal.DailyFoodNeed <= 0)
                        {
                            Console.WriteLine($"{animalName} was successfully fed");
                            animals.Remove(currentAnimal);
                        }
                    }
                }
            }

            Dictionary<string, int> areas = new Dictionary<string, int>();

            Console.WriteLine("Animals:");
            foreach (Animal animal in animals)
            {
                Console.WriteLine($" {animal.Name} -> {animal.DailyFoodNeed}g");
                if (!areas.ContainsKey(animal.LivingArea))
                {
                    areas.Add(animal.LivingArea, 0);
                }

                areas[animal.LivingArea]++;
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (KeyValuePair<string, int> area in areas)
            {
                Console.WriteLine($" {area.Key}: {area.Value}");
            }
        }
    }

    class Animal
    {
        public Animal(string name, string livingArea)
        {
            Name = name;
            LivingArea = livingArea;
        }

        public string Name { get; set; }
        public int DailyFoodNeed { get; set; }
        public string LivingArea { get; set; }
    }
}
