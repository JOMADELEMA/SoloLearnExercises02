using System;

namespace _18_TeamWorkMakesTheDreamWork
{
    internal class Program
    {
        /*
         * You and your friend are playing a game as one team. 
         * Each player must pas 2 rounds and gets points for 
         * each round passed. 
         * 
         * The program you are given creates two Score objects
         * Where each round scores are stored (They are passed to 
         * a constructor)
         * Overload the + operator for the Score class to calculate 
         * the team score for every round. 
         * 
         * 
         */
        static void Main(string[] args)
        {
            Score tm1 = new Score(2, 3);
            Score tm2 = new Score(4, 2);

            Score finalScores = tm1 + tm2;

            Console.WriteLine("Round 1: " + finalScores.round1Score);
            Console.WriteLine("Round 2: " + finalScores.round2Score);
        }

        class Score
        {
            public int round1Score { get; set; }
            public int round2Score { get; set; }
            public Score(int r1, int r2)
            {
                round1Score = r1;
                round2Score = r2;
            }

            public static Score operator +(Score s1, Score s2)
            {
                int round1ScoreSum = s1.round1Score + s2.round1Score;
                int round2ScoreSum = s1.round2Score + s2.round2Score;

                Score res = new Score(round1ScoreSum, round2ScoreSum);
                return res;
            }
        }
    }
}