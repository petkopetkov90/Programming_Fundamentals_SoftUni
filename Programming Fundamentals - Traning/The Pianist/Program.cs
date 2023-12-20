namespace The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int piecesCount = int.Parse(Console.ReadLine());
            List<Piece> pieces = new List<Piece>();
            for (int i = 0; i < piecesCount; i++)
            {
                string[] piceDetails = Console.ReadLine().Split("|");
                string pieceName = piceDetails[0];
                string composer = piceDetails[1];
                string key = piceDetails[2];
                pieces.Add(new Piece(pieceName, composer, key));
            }
            string commands;
            while ((commands = Console.ReadLine()) != "Stop")
            {
                string[] commandDetails = commands.Split("|");
                string command = commandDetails[0];
                string pieceName = commandDetails[1];
                switch (command)
                {
                    case "Add":
                        string composer = commandDetails[2];
                        string key = commandDetails[3];
                        AddNewPiece(pieces, pieceName, composer, key);
                        break;
                    case "Remove":
                        RemovePiece(pieces, pieceName);
                        break;
                    case "ChangeKey":
                        string newKey = commandDetails[2];
                        ChangeKey(pieces, pieceName, newKey);
                        break;
                }
            }

            Console.WriteLine(string.Join("\n", pieces));
        }

        private static void ChangeKey(List<Piece> pieces, string pieceName, string newKey)
        {
            if (pieces.Any(x => x.Name == pieceName))
            {
                pieces.First(x => x.Name == pieceName).Key = newKey;
                Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
                return;
            }

            Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
        }

        private static void RemovePiece(List<Piece> pieces, string pieceName)
        {
            if (!pieces.Any(x => x.Name == pieceName))
            {
                Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                return;
            }

            Console.WriteLine($"Successfully removed {pieceName}!");
            pieces.Remove(pieces.First(x => x.Name == pieceName));
        }

        private static void AddNewPiece(List<Piece> pieces, string pieceName, string composer, string key)
        {
            if (pieces.Any(x => x.Name == pieceName))
            {
                Console.WriteLine($"{pieceName} is already in the collection!");
                return;
            }

            Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
            pieces.Add(new Piece(pieceName, composer, key));
        }
    }
    class Piece
    {
        public Piece(string name, string composer, string key)
        {
            Name = name;
            Composer = composer;
            Key = key;
        }

        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
        public override string ToString()
        {
            return $"{Name} -> Composer: {Composer}, Key: {Key}";
        }
    }
}
