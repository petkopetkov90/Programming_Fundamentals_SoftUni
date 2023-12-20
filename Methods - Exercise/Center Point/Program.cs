namespace Center_Podouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            NearestPodouble(x1, y1, x2, y2);
        }
        static void NearestPodouble(double x1, double y1, double x2, double y2)
        {
            if (Math.Abs(x1 - 0) + Math.Abs(y1 - 0) <= Math.Abs(x2 - 0) + Math.Abs(y2 - 0))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}