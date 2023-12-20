namespace Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine().Split(", ").ToList();

            foreach (string username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool isValid = true;

                    for (int i = 0; i < username.Length; i++)
                    {
                        if (!char.IsDigit(username[i]) && !char.IsLetter(username[i]) && username[i] != '_' && username[i] != '-')
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}
