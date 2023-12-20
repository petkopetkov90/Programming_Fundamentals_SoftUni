namespace Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPeople = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < totalPeople; i++)
            {
                string[] personDetails = Console.ReadLine()
                    .Split()
                    .ToArray();

                Person person = new Person();
                person.Name = personDetails[0];
                person.Age = int.Parse(personDetails[1]);
                family.Persons.Add(person);
            }
            Console.Write($"{family.GetOldestMember(family.Persons).Name} ");
            Console.WriteLine($"{family.GetOldestMember(family.Persons).Age}");

        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Family
    {
        public Family()
        {
            Persons = new List<Person>();
        }
        public List<Person> Persons { get; set; }

        public void AddFamilyMember(Person person)
        {
            Persons.Add(person);
        }
        public Person GetOldestMember(List<Person> persons)
        {
            return persons.MaxBy(person => person.Age);
        }
    }
}