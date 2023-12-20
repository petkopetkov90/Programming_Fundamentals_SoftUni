namespace Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double studentsCount = double.Parse(Console.ReadLine());
            double lectures = double.Parse(Console.ReadLine());
            double additionalBonus = double.Parse(Console.ReadLine());

            double maxBonus = double.MinValue;
            double maxAttendance = double.MinValue;

            if (studentsCount == 0 || lectures == 0)
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");
                return;
            }

            for (int i = 0; i < studentsCount; i++)
            {
                double attendance = double.Parse(Console.ReadLine());
                double currentBonus = attendance / lectures * (5.00 + additionalBonus);

                if (currentBonus > maxBonus)
                {
                    maxBonus = currentBonus;
                    maxAttendance = attendance;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}