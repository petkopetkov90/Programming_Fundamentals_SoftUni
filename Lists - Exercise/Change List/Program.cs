namespace Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<string> commands = Console.ReadLine()
                .Split()
                .ToList();

            while (commands[0] != "end")
            {
                if (commands[0] == "Delete")
                {
                    numbers.RemoveAll(element => element == int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }

                commands = Console.ReadLine()
                .Split()
                .ToList();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}