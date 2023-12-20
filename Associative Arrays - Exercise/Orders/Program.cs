namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> productsDetailsPair = new Dictionary<string, Product>();
            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] productDetails = input.Split();
                Product product = new Product(productDetails[0]);

                if (!productsDetailsPair.ContainsKey(productDetails[0]))
                {
                    productsDetailsPair.Add(productDetails[0], product);
                }

                productsDetailsPair[productDetails[0]].Price = decimal.Parse(productDetails[1]);
                productsDetailsPair[productDetails[0]].Quantity += decimal.Parse(productDetails[2]);
            }

            foreach (KeyValuePair<string, Product> productPair in productsDetailsPair)
            {
                Console.WriteLine($"{productPair.Key} -> {productPair.Value.Price * productPair.Value.Quantity:F2}");
            }
        }
    }

    public class Product
    {
        public Product(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }
    }
}