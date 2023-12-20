namespace Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < totalArticles; i++)
            {
                string[] articleArray = Console.ReadLine()
                .Split(", ")
                .ToArray();
                Article article = new Article();
                article.Title = articleArray[0];
                article.Content = articleArray[1];
                article.Author = articleArray[2];
                articles.Add(article);
            }

            Console.WriteLine(string.Join("\n", articles));
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
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

}