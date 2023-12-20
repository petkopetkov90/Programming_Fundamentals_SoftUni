namespace Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal saving = decimal.Parse(Console.ReadLine());
            List<int> qualityOfDrums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;

            List<int> startingQuality = new List<int>();
            for (int i = 0; i < qualityOfDrums.Count; i++)
            {
                startingQuality.Add(qualityOfDrums[i]);
            }

            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);
                DecreaseQuality(qualityOfDrums, hitPower);
                saving = BuyNewDrums(startingQuality, qualityOfDrums, saving);
            }

            Console.WriteLine(string.Join(" ", qualityOfDrums));
            Console.WriteLine($"Gabsy has {saving:f2}lv.");
        }

        static decimal BuyNewDrums(List<int> startingQuality, List<int> qualityOfDrums, decimal saving)
        {

            for (int i = 0; i < qualityOfDrums.Count; i++)
            {
                if (qualityOfDrums[i] <= 0)
                {
                    if (saving - (startingQuality[i] * 3) >= 0)
                    {
                        qualityOfDrums[i] = startingQuality[i];
                        saving -= (startingQuality[i] * 3);
                    }
                    else
                    {
                        qualityOfDrums.RemoveAt(i);
                        startingQuality.RemoveAt(i);
                        i--;
                    }
                }
            }
            return saving;
        }

        static void DecreaseQuality(List<int> qualityOfDrums, int hitPower)
        {
            for (int i = 0; i < qualityOfDrums.Count; i++)
            {
                qualityOfDrums[i] -= hitPower;
            }
        }
    }
}