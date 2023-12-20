namespace Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (secondDeck.Count > 0 && firstDeck.Count > 0)
            {
                if (firstDeck[0] > secondDeck[0])
                {
                    FirstDeckWins(firstDeck, secondDeck);
                }
                else if (firstDeck[0] < secondDeck[0])
                {
                    SecondDeckWinds(firstDeck, secondDeck);
                }
                else
                {
                    Draw(firstDeck, secondDeck);
                }
            }

            int sum = 0;

            if (firstDeck.Count == 0)
            {
                for (int i = 0; i < secondDeck.Count; i++)
                {
                    sum += secondDeck[i];
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else
            {
                for (int i = 0; i < firstDeck.Count; i++)
                {
                    sum += firstDeck[i];
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
        }

        static void Draw(List<int> firstDeck, List<int> secondDeck)
        {
            secondDeck.RemoveAt(0);
            firstDeck.RemoveAt(0);
        }

        static void SecondDeckWinds(List<int> firstDeck, List<int> secondDeck)
        {
            secondDeck.Add(firstDeck[0]);
            secondDeck.Add(secondDeck[0]);
            secondDeck.RemoveAt(0);
            firstDeck.RemoveAt(0);
        }

        static void FirstDeckWins(List<int> firstDeck, List<int> secondDeck)
        {
            firstDeck.Add(secondDeck[0]);
            firstDeck.Add(firstDeck[0]);
            secondDeck.RemoveAt(0);
            firstDeck.RemoveAt(0);
        }
    }
}