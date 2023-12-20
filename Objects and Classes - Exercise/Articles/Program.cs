namespace Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleArray = Console.ReadLine()
                .Split(", ")
                .ToArray();
            Article article = new Article();
            article.Title = articleArray[0];
            article.Content = articleArray[1];
            article.Author = articleArray[2];
            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ")
                    .ToArray();
                if (command[0] == "Edit")
                {
                    article.EditContent(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    article.RenameTitle(command[1]);
                }
            }

            Console.WriteLine(article);
        }
    }

    public class Article
    {
        public Article()
        {

        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void EditContent(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void RenameTitle(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

}