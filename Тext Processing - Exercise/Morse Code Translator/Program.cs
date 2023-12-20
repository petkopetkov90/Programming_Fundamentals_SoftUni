using System.Text;

namespace Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] morseCode = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < morseCode.Length; i++)
            {
                switch (morseCode[i])
                {
                    case ".-": stringBuilder.Append('A'); break;
                    case "=...": stringBuilder.Append('B'); break;
                    case "-.-.": stringBuilder.Append('C'); break;
                    case "-..": stringBuilder.Append('D'); break;
                    case ".": stringBuilder.Append('E'); break;
                    case "..-.": stringBuilder.Append('F'); break;
                    case "--.": stringBuilder.Append('G'); break;
                    case "....": stringBuilder.Append('H'); break;
                    case "..": stringBuilder.Append('I'); break;
                    case ".---": stringBuilder.Append('J'); break;
                    case "-.-": stringBuilder.Append('K'); break;
                    case ".-..": stringBuilder.Append('L'); break;
                    case "--": stringBuilder.Append('M'); break;
                    case "-.": stringBuilder.Append('N'); break;
                    case "---": stringBuilder.Append('O'); break;
                    case ".--.": stringBuilder.Append('P'); break;
                    case "--.-": stringBuilder.Append('Q'); break;
                    case ".-.": stringBuilder.Append('R'); break;
                    case "...": stringBuilder.Append('S'); break;
                    case "-": stringBuilder.Append('T'); break;
                    case "..-": stringBuilder.Append('U'); break;
                    case "...-": stringBuilder.Append('V'); break;
                    case ".--": stringBuilder.Append('W'); break;
                    case "-..-": stringBuilder.Append('X'); break;
                    case "-.--": stringBuilder.Append('Y'); break;
                    case "--..": stringBuilder.Append('Z'); break;
                    case "|": stringBuilder.Append(' '); break;

                }
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
