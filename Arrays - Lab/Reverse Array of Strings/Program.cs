using System;
using System.Linq;

namespace Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();

            Array.Reverse(array);

            Console.WriteLine(string.Join(" ", array));  
        }
    }
}