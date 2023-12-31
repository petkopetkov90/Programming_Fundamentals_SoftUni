﻿namespace Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int messages = int.Parse(Console.ReadLine());
            Random random = new Random();
            List<Advertisement> advertisements = new List<Advertisement>();

            for (int i = 0; i < messages; i++)
            {
                Advertisement ad = new Advertisement();
                ad.Phrase = phrases[random.Next(phrases.Length)];
                ad.Event = events[random.Next(events.Length)];
                ad.Author = authors[random.Next(authors.Length)];
                ad.City = cities[random.Next(cities.Length)];
                advertisements.Add(ad);
            }

            foreach (Advertisement ad in advertisements)
            {
                Console.WriteLine($"{ad.Phrase} {ad.Event} {ad.Author} – {ad.City}.");
            }
        }
    }
    public class Advertisement
    {
        public string Phrase { get; set; }
        public string Event { get; set; }
        public string Author { get; set; }
        public string City { get; set; }
    }
}