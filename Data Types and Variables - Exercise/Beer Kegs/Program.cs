using System;

namespace Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte kegs = byte.Parse(Console.ReadLine());

            double maxVolume = double.MinValue;
            string maxName = string.Empty;

            for (int i = 0; i < kegs; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * (radius * radius) * height;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    maxName = model;
                }
            }
            Console.WriteLine(maxName);
        }
    }
}