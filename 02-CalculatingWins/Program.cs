using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _02_CalculatingWins
{
    internal class Program
    {

        /*
         * We are developing a profile system for a player of our online game. 
         * The program already takes the number of games and wins as input
         * and create a player object. 
         * Complete the GetWinRate() method inside the given Player
         * class to calculate and output the win rate. 
         * 
         * Sample input:
         * 130
         * 70
         * 
         * Sample output:
         * 53
         * 
         * Explanation:
         * win rate is calculated by this formula: wins*100/games. 
         * the final result should be an integer.
         */
        static void Main(string[] args)
        {
            int games = Convert.ToInt32(Console.ReadLine());
            int wins = Convert.ToInt32(Console.ReadLine());

            Player player1 = new Player();
            player1.Games = games;
            player1.Wins = wins;

            player1.GetWinRate();
            
        }

        class Player
        {
            public int Games;
            public int Wins;
            private int Winrate;

            public void GetWinRate()
            {
                Winrate = Wins * 100 / Games;
                Console.WriteLine(Convert.ToInt32(Winrate));
            }
        }
    }
}
