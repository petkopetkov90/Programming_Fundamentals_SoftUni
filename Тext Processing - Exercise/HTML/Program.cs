using System.Text;

namespace HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            string comment;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<h1>");
            stringBuilder.AppendLine($"    {title}");
            stringBuilder.AppendLine("</h1>");
            stringBuilder.AppendLine("<article>");
            stringBuilder.AppendLine($"    {content}");
            stringBuilder.AppendLine("</article>");

            while ((comment = Console.ReadLine()) != "end of comments")
            {
                stringBuilder.AppendLine("<div>");
                stringBuilder.AppendLine($"    {comment}");
                stringBuilder.AppendLine("</div>");
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
