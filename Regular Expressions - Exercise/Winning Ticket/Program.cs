using System.Text.RegularExpressions;

namespace Winning_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                .ToArray();

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");                  
                }
                else
                {
                    string ticketFirstPart = tickets[i].Substring(0, 10);
                    string ticketSecondPart = tickets[i].Substring(10);

                    string symbolPatter = @"(?<symbol>[\@\$\#\^])\k<symbol>{5,}";
                    Regex regex = new Regex(symbolPatter);
                    Match match1 = regex.Match(ticketFirstPart);
                    Match match2 = regex.Match(ticketSecondPart);

                    if (match1.Success && match2.Success)
                    {
                        string symbol = match1.Groups["symbol"].Value;
                        if (Math.Min(match1.Length, match2.Length) == 10)
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {match1.Length}{symbol} Jackpot!");
                            continue;
                        }

                        Console.WriteLine($"ticket \"{tickets[i]}\" - {Math.Min(match1.Length, match2.Length)}{symbol}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                        continue;
                    }
                }
            }
        }
    }
}
