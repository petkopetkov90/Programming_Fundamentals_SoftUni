namespace Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int lastIndex = path.LastIndexOf("\\");
            path = path.Substring(lastIndex + 1);
            int indexEndOfFileName = path.LastIndexOf(".");
            string extensionsName = path.Substring(indexEndOfFileName + 1);
            string fileName = path.Substring(0, indexEndOfFileName);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extensionsName}");
        }
    }
}
