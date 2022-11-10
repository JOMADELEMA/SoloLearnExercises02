using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_WhoWon
{
    internal class Program
    {
        /*
         * Five participants have advanced to the final round of a 
         * TV trivia show, and it is timpe to announce the winner. 
         * and end the game. 
         * The program you are given defines the array of finalists,
         * takes the index of the winner as input, and creates the 
         * FinalRound object. 
         * 
         * Complete the FinalRound class by writing the needed code 
         * in constructor to take the array and the winner index 
         * as parameters and output the corresponding message to show 
         * the winner. Then create a destructor to finish the game 
         * and output "Game Over".
         * 
         * Sample input 2
         * Sample output
         * Winner is Leyla Brown 
         * Game Over
         * 
         */
        static void Main(string[] args)
        {
            string[] finalists = { "James Van", "John Smith", "Leyla Brown", "Tom Homerton", "Bob Douglas" };
            int winner = Convert.ToInt32(Console.ReadLine());

            FinalRound finalround = new FinalRound(finalists, winner);


        }

        class FinalRound
        {
            public FinalRound(string[] finalists, int winner)
            {
                Console.WriteLine("Winner is " + finalists[winner]);
            }
            ~FinalRound(){
                Console.WriteLine("Game Over");
            }
        }
    }
}
