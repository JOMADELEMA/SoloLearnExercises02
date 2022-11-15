using System;

namespace QualifiyingForTheOlympics
{
    internal class Program
    {
        /*
         * The qualifiers for the Olympiad lasts 3 days, and one
         * winner is selected each qualifying day. 
         * The jagged array you are given represents the list of 
         * all participands, divided by the number of days
         * (There are 3 arrays inside the main one, each 
         * representing the participans who took part on that day).
         * 
         * Write a program to take the numbers of each day's winners 
         * as input and output them.
         * 
         * Sample input:
         * 2
         * 3
         * 4
         * 
         * Sample Output
         * Bridgette Ramona
         * Fran Mayur
         * Kristian Dana
         * 
         */

        static void Main(string[] args)
        {
            int day1Winner = Convert.ToInt32(Console.ReadLine());
            int day2Winner = Convert.ToInt32(Console.ReadLine());
            int day3Winner = Convert.ToInt32(Console.ReadLine());


            string[][] olympiad = new string[][]
            {
                //day 1 - 5 participants
                new string[] { "Jill Yan", "Bridgette Ramona", "Sree Sanda", "Jareth Charlene", "Carl Soner" },
                //day 2 - 7 participants
                new string[] { "Anna Hel", "Mariette Vedrana", "Fran Mayur", "Drake Hilmar", "Nikolay Brooks", "Eliana Vlatko", "Villem Mario" },
                //day 3 - 4 participants
                new string[] { "Hieremias Zavia", "Ziya Ollie", "Christoffel Casper", "Kristian Dana", }
            };

            int[] winners = { day1Winner, day2Winner, day3Winner };

            for (int i = 0; i < olympiad.Length; i++)
                Console.WriteLine(olympiad[i][(winners[i] - 1)]);
        }
    }
}