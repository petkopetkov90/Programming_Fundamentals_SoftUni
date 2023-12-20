using System.Linq;

namespace Shopping_Spree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] totalPeoples = Console.ReadLine()
                .Split(";")
                .ToArray();

            List<Product> products = new List<Product>();
            List<Person> persons = new List<Person>();

            for (int i = 0; i < totalPeoples.Length; i++)
            {
                string[] personDetails = totalPeoples[i].Split("=");
                Person person = new Person();
                person.Name = personDetails[0];
                person.Money = double.Parse(personDetails[1]);
                persons.Add(person);
            }

            string[] totalProducts = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < totalProducts.Length; i++)
            {
                string[] productDetails = totalProducts[i].Split("=");
                Product product = new Product();
                product.Name = productDetails[0];
                product.Price = double.Parse(productDetails[1]);
                products.Add(product);
            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] orders = command.Split();

                Person person = persons.First(person => person.Name == orders[0]);
                Product product = products.First(product => product.Name == orders[1]);
                if (person.Money < product.Price)
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }
                else
                {
                    person.Money -= product.Price;
                    person.BagOfProducts.Add(product);
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
            }

            Console.WriteLine(string.Join("\n", persons));
        }
    }

    class Person
    {
        public Person()
        {
            BagOfProducts = new List<Product>();
        }
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> BagOfProducts { get; set; }
        public override string ToString()
        {
            if (BagOfProducts.Count > 0)
                return $"{Name} - " + GetBag(BagOfProducts);
            else
                return $"{Name} - " + "Nothing bought";
        }

        public string GetBag(List<Product> bagOfProducts)
        {
            string products = "";

            for (int i = 0; i < bagOfProducts.Count - 1; i++)
            {
                products += bagOfProducts[i].Name + ", ";
            }

            products += bagOfProducts[bagOfProducts.Count - 1].Name;
            return products;
        }
    }
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}