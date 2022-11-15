using System;

namespace _07_OnlyTheEvens
{
    internal class Program
    {
        /*
         * The program you are given takes 5 numbers as input
         * and stores them in an array. 
         * Complete the program to go through the array and 
         * output the sume of even numbers. 
         * 
         * sample input
         * 10
         * 890
         * 15
         * 3699
         * 14
         * 
         * sample output 
         * 914
         */
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int count = 0;

            while (count < 5)
            {
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }

            int sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                    sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}