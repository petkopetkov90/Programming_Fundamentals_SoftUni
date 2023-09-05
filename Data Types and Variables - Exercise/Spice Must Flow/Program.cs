using System;

namespace Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint yield = uint.Parse(Console.ReadLine());

            bool abadon = false;
            int days = 0;
            long storage = 0;

            while (!abadon)
            {
                if (yield < 100)
                {
                    abadon = true;
                    if (storage < 26)
                    {
                        storage -= storage;
                    }
                    else
                    {
                        storage -= 26;
                    }
                    break;
                }
                days++;
                storage += yield;
                if (storage < 26)
                {
                    storage -= storage;
                }
                else
                {
                    storage -= 26;
                }
                yield -= 10;
            }

            Console.WriteLine(days);
            Console.WriteLine(storage);
        }
    }
}