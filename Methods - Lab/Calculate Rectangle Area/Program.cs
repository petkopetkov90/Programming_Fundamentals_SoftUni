namespace Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = AreaOfRectangle(a, b);

            Console.WriteLine(area);

        }

        static double AreaOfRectangle(double width, double height)
        {
            return width * height;
        }
    }
}