namespace Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split(" -> ");
                string companyName = commands[0];
                string employeeID = commands[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }

                if (!companies[companyName].Contains(employeeID))
                {
                    companies[companyName].Add(employeeID);
                }
            }

            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");
                Console.WriteLine("-- " + string.Join("\n-- ", company.Value));
            }
        }
    }
}