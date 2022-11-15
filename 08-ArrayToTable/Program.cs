using System;

namespace _08_ArrayToTable
{
    internal class Program
    {
        /*
         * Complete the program to output this array in the form of a table (without separation):
         * 123
         * 456
         * 789
         * 
         */
        static void Main(string[] args)
        {
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(num[i, j]);
                Console.WriteLine();
            }
        }
    }
}