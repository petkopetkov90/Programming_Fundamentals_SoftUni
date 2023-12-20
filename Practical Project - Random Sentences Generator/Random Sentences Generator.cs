namespace Practical_Project___Random_Sentences_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Peter", "John", "Mikael", "Steve", "Pedro", "Arnold", "Robert", "Bob", "Vladimir", "Vin", "Boris", "Marius", "Leo", "Jane", "Molly", "Scarlet", "Aria", "Anna", "Petra", "Mercedes", "Mila", "Sofia", "Berta", "Cristine", "Maria", "Jessica", "Lana", "Rachel", "Monika", "Phoebe", "Joey", "Ross", "Rob", "Chandler", "Mark", "Cesar", "Elena", "Bonnie", "Damon", "Alaric", "Hope", "Claus", "Elijah", "Rebeca" };

            string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas", "Vidin", "Athens", "Pleven", "Belgrade", "Kavala", "Nurnberg", "Paris", "Madrid", "LA", "Orlando", "Kansas", "Ottawa", "Mexico", "Rio", "Cairo", "Nice", "Rome", "Palermo", "Reims" };

            string[] verbs = { "eat", "hold", "see", "play", "bring", "watch", "bake", "run", "chase", "swim", "love", "want", "have" };

            string[] nouns = { "stone", "cake", "coffee", "apple", "bike", "TV", "laptop", "car", "table", "bottle", "shoes", "book", "pencil", "game" };

            string[] adverbs = { "slowly", "warmly", "sadly", "rapidly", "diligently", "quickly", "never", "incredibly", "quite", "happily", "energetically", "loudly", "shortly", "briefly", "yearly", "hourly", "extremely" };

            string[] details = { "near the river", "at home", "in the park", "outside", "upstairs", "downtown", "near the lake", "on the beach", "on the street", "in Europe", "far away", "at home" };

            Console.WriteLine("This is Random Sentence Generator");

            while (true)
            {
                Console.WriteLine("Pres Enter to generate new random sentence");
                Console.ReadLine();

                string randomName = RandomWord(names);
                string randomPlace = RandomWord(places);
                string randomVerb = RandomWord(verbs);
                string randomNoun = RandomWord(nouns);
                string randomAdverb = RandomWord(adverbs);
                string randomDetails = RandomWord(details);

                string who = $"{randomName} from {randomPlace}";
                string action = $"{randomAdverb} {randomVerb} {randomNoun}";
                string sentence = $"{who} {action} {randomDetails}";

                Console.WriteLine(sentence);

            }

        }

        static string RandomWord(string[] words)
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string word = words[randomIndex];
            return word;
        }
    }
}