namespace A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> resourcesQuantityPair = new Dictionary<string, double>();
            string input;
            while((input = Console.ReadLine()) != "stop")
            {
                string resource = input;
                double quantity = double.Parse(Console.ReadLine());

                if (!resourcesQuantityPair.ContainsKey(resource))
                {
                    resourcesQuantityPair.Add(resource, 0);
                }

                resourcesQuantityPair[resource] += quantity;
            }

            foreach (KeyValuePair<string, double> pair in resourcesQuantityPair)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}