using System;
using System.Linq;

namespace _10_MaximumAndMinimum
{
    internal class Program
    {
        /*
         * Write a program to take 5 numbers as input, then calculate and 
         * output the sum of the maximum and the minimum inputed values. 
         * 
         * Sample input
         * 5
         * 6
         * 14
         * 2
         * 1
         * 
         * Sample output. 
         * 15
         * 
         */
        static void Main(string[] args)
        {
            int counter = 0;
            int[] nums = new int[5];

            while (counter < 5)
            {
                nums[counter] = Convert.ToInt32(Console.ReadLine());
                counter++;
            }

            Console.WriteLine(nums.Min() + nums.Max());
        }
    }
}