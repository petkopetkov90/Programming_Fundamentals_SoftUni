using System;

namespace Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            string output = string.Empty;

            if (day == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    output = "12$";
                }
                else if (age > 18 && age <= 64)
                {
                    output = "18$";
                }
                else if (age > 64 && age <= 122)
                {
                    output = "12$";
                }
                else
                {
                    output = "Error!";
                }
            }
            else if (day == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    output = "15$";
                }
                else if (age > 18 && age <= 64)
                {
                    output = "20$";
                }
                else if (age > 64 && age <= 122)
                {
                    output = "15$";
                }
                else
                {
                    output = "Error!";
                }
            }
            else if (day == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    output = "5$";
                }
                else if (age > 18 && age <= 64)
                {
                    output = "12$";
                }
                else if (age > 64 && age <= 122)
                {
                    output = "10$";
                }
                else
                {
                    output = "Error!";
                }
            }
            else
            {
                output = "Error!";
            }

            Console.WriteLine(output);
        }
    }
}