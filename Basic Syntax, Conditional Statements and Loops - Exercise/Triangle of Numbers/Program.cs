﻿using System;

namespace Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= num; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write(rows);
                    if (cols < rows)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}