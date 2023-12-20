using System.Text;

namespace String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder stringBuilder = new StringBuilder();

            int explosions = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    explosions += int.Parse(text[i + 1].ToString());
                    stringBuilder.Append(text[i]);
                    continue;
                }
                if (explosions == 0)
                {
                    stringBuilder.Append(text[i]);
                }
                else
                {
                    explosions--;
                }
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
