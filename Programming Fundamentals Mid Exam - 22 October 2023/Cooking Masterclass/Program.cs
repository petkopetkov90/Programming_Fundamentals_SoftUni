namespace Cooking_Masterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double singleEggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());
            double flourCost = (students - (students / 5)) * flourPrice;
            double eggsCost = students * 10 * singleEggPrice;
            double apronsCost = Math.Ceiling(students * 1.20) * apronPrice;
            double totalExpenses = flourCost + eggsCost + apronsCost;

            if (budget >= totalExpenses)
            {
                Console.WriteLine($"Items purchased for {totalExpenses:f2}$.");
            }
            else
            {
                Console.WriteLine($"{totalExpenses - budget:f2}$ more needed.");
            }
        }
    }
}