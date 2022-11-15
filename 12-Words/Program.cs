using System;

namespace _12_Words
{
    internal class Program
    {
        /*
         * The program you are given defines an array with 10 words and
         * takes a letter as input. 
         * Write a program to iterate through the array and output 
         * the words containing the taken letter. 
         * If there is no such word, the program should output
         * "No match".
         * 
         * Sample input: u
         * Sample output: fun
         */
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;

            foreach (var word in words)
            {
                if (word.Contains(letter))
                {
                    Console.WriteLine(word);
                    count++;
                }
            }
            if (count == 0)
                Console.WriteLine("No match");
        }
    }
}