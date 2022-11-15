using System;

namespace _15_ArraySorting
{
    internal class Program
    {
        /*
         * The program you are given takes the N number as the
         * size of an array, followed by N numbers. 
         * Complete the program to sort and output every 
         * element of an array, each on a new line. 
         * 
         * Sample input
         * 4
         * 1
         * 114
         * 3
         * 5
         * 
         * Sample output
         * 1
         * 3
         * 5
         * 14
         * 
         */
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            Array.Sort(numbers);

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}