namespace Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] command = Console.ReadLine()
                    .Split("_")
                    .ToArray();

                Song newSong = new Song();
                newSong.TypeList = command[0];
                newSong.Name = command[1];
                newSong.Time = command[2];

                songs.Add(newSong);
            }

            string type = Console.ReadLine();

            for (int i = 0; i < songs.Count; i++)
            {
                if (type == "all")
                {
                    Console.WriteLine(string.Join("\n", songs[i].Name));
                }
                else if (type == songs[i].TypeList)
                {
                    Console.WriteLine(string.Join("\n", songs[i].Name));
                }
            }
        }
    }
    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}