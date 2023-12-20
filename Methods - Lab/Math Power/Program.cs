namespace Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(RaisedNumber(number, power));
        }

        static double RaisedNumber(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}