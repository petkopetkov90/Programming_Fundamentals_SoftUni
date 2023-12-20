namespace Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x11 = double.Parse(Console.ReadLine());
            double y11 = double.Parse(Console.ReadLine());
            double x12 = double.Parse(Console.ReadLine());
            double y12 = double.Parse(Console.ReadLine());
            double x21 = double.Parse(Console.ReadLine());
            double y21 = double.Parse(Console.ReadLine());
            double x22 = double.Parse(Console.ReadLine());
            double y22 = double.Parse(Console.ReadLine());

            double line1 = LongerLine(x11, y11, x12, y12);
            double line2 = LongerLine(x21, y21, x22, y22);

            if (line1 >= line2)
            {
                NearestPointFirst(x11, y11, x12, y12);
            }
            else
            {
                NearestPointFirst(x21, y21, x22, y22);
            }
        }

        static double LongerLine(double x1, double y1, double x2, double y2)
        {
            double sideA = Math.Abs(x1 - x2);
            double sideB = Math.Abs(y1 - y2);
            return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }

        static void NearestPointFirst(double x1, double y1, double x2, double y2)
        {
            if (Math.Abs(x1 - 0) + Math.Abs(y1 - 0) <= Math.Abs(x2 - 0) + Math.Abs(y2 - 0))
            {
                Console.Write($"({x1}, {y1})");
                Console.Write($"({x2}, {y2})");
            }
            else
            {
                Console.Write($"({x2}, {y2})");
                Console.Write($"({x1}, {y1})");
            }
        }
    }
}