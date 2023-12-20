namespace Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Person> persons = new List<Person>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] information = input.Split()
                    .ToArray();

                Person person = new Person();
                string name = information[0];
                string id = information[1];
                int age = int.Parse(information[2]);

                if (persons.Any(person => person.Id == id))
                {
                    int index = persons.FindIndex(person => person.Id == id);
                    persons[index].Age = age;
                    persons[index].Name = name;
                    continue;
                }

                person.Name = name;
                person.Id = id;
                person.Age = age;
                persons.Add(person);
            }

            persons = persons.OrderBy(person => person.Age).ToList();
            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
            
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}