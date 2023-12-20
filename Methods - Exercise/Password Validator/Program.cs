using System;

namespace Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!CheckForLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!CheckForType(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!CheckFrMinDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (CheckForLength(password) && CheckForType(password) && CheckFrMinDigits(password))
            {
                Console.WriteLine("Password is valid");
            }

        }
        static bool CheckForLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
        static bool CheckForType(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!Char.IsLetterOrDigit(password[i]))
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckFrMinDigits(string password)
        {
            int digits = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    digits++;
                    if (digits >= 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}