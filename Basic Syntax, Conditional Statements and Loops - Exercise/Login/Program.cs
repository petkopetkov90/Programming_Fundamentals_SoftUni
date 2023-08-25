using System;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            
            string correctPassword = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                correctPassword += username[i];
            }

            int incorectCounter = 0;

            while (true)
            {
                string password = Console.ReadLine();

                if (password == correctPassword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    incorectCounter++;
                    if (incorectCounter > 3)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}