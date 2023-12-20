namespace SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int emp1AnsPerHour = int.Parse(Console.ReadLine());
            int emp2AnsPerHour = int.Parse(Console.ReadLine());
            int emp3SAnsPerHour = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int employeesTotalAnsPerHour = emp1AnsPerHour + emp2AnsPerHour + emp3SAnsPerHour;

            int totalHoursNeeded = (int)Math.Ceiling((decimal)students / employeesTotalAnsPerHour);

            if (totalHoursNeeded > 3)
            {
                totalHoursNeeded += (totalHoursNeeded -1) / 3;
            }

            if (totalHoursNeeded < 0)
            {

            }

            Console.WriteLine($"Time needed: {totalHoursNeeded}h.");
        }
    }
}
