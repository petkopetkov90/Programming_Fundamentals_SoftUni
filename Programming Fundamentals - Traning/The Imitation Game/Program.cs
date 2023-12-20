using System.Linq.Expressions;

namespace The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMSG = Console.ReadLine();
            string instrunction;
            while((instrunction = Console.ReadLine()) != "Decode")
            {
                string[] commands = instrunction.Split("|");
                string command = commands[0];
                switch (command)
                {
                    case "Move":
                        int letterCount = int.Parse(commands[1]);
                        encryptedMSG = MoveLetters(encryptedMSG,letterCount);
                        break;
                    case "Insert":
                        int index = int.Parse(commands[1]);
                        string value = commands[2];
                        encryptedMSG = InsertLetters(encryptedMSG,index,value);
                        break;
                    case "ChangeAll":
                        string substring = commands[1];
                        string replacement = commands[2];
                        encryptedMSG = ChangeLetters(encryptedMSG, substring, replacement);
                        break;
                }
            }
            Console.WriteLine($"The decrypted message is: {encryptedMSG}");
        }

        private static string ChangeLetters(string encryptedMSG, string substring, string replacement)
        {
            return encryptedMSG.Replace(substring, replacement);
        }

        private static string InsertLetters(string encryptedMSG, int index, string value)
        {
            return encryptedMSG.Insert(index,value);
        }

        private static string MoveLetters(string encryptedMSG, int letterCount)
        {
            string firstLetter = encryptedMSG.Substring(0, letterCount);
            string newMSG = encryptedMSG.Replace(firstLetter, "");
            return newMSG + firstLetter;
            
        }
    }
}
