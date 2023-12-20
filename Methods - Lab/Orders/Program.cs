namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Calculate(product, quantity);
        }

        static void Calculate(string product, int quantity)
        {
            decimal price = 0; 

            if (product == "coffee")
            {
                price = 1.50m;
            }
            else if (product == "water")
            {
                price = 1.00m;
            }
            else if (product == "coke")
            {
                price = 1.40m;
            }
            else if (product == "snacks")
            {
                price = 2.00m;
            }

            Console.WriteLine(quantity * price);
        }
    }
}