namespace School_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine()
                .Split("&")
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] commands = input.Split(" | ").ToArray();

                switch (commands[0])
                {
                    case "Add Book":
                        AddBookAtFirstPlace(books, commands[1]);
                        break;
                    case "Take Book":
                        RemoveBook(books, commands[1]);
                        break;
                    case "Swap Books":
                        SwapBooks(books, commands[1], commands[2]);
                        break;
                    case "Insert Book":
                        AddBookOnEnd(books, commands[1]);
                        break;
                    case "Check Book":
                        PrintNameOfBook(books, int.Parse(commands[1]));
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", books));
        }

        static void AddBookAtFirstPlace(List<string> books, string bookName)
        {
            if (books.Contains(bookName))
            {
                return;
            }
            books.Insert(0, bookName);
        }

        static void RemoveBook(List<string> books, string bookName)
        {
            books.Remove(bookName);
        }

        static void SwapBooks(List<string> books, string book1, string book2)
        {
            if (books.Contains(book1) && books.Contains(book2))
            {
                int index1 = books.IndexOf(book1);
                int index2 = books.IndexOf(book2);
                string temp = books[index1];
                books[index1] = books[index2];
                books[index2] = temp;
            }
        }

        static void AddBookOnEnd(List<string> books, string bookName)
        {
            if (books.Contains(bookName))
            {
                return;
            }
            books.Add(bookName);
        }

        static void PrintNameOfBook(List<string> books, int index)
        {
            if (index >= 0 && index < books.Count)
            {
                Console.WriteLine(books[index]);
            }
        }
    }
}