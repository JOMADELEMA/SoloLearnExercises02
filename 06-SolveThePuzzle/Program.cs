using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SolveThePuzzle
{
    internal class Program
    {

        /*
         * A game machine has 5 games installed on it:
         * 
         * Alien Shooter
         * Tic Tac Toe
         * Snake
         * Puzzle 
         * Football
         * 
         * Write a program to take N numbers as input and output the 
         * corresponding game with N index from the array. 
         * If user enters an invalid number that is out of the array
         * range, the program should output "Invalid Number". 
         * 
         * Sample input: 3
         * Output: Puzzle
         */

        static void Main(string[] args)
        {
            string[] games = { "Alien shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };

            int userInput = Convert.ToInt32(Console.ReadLine());

            //Solved with value comparison assuming no try catch possible
            //if(userInput >4 || userInput < 0)
            //{
            //    Console.WriteLine("Invalid number");
            //}
            //else
            //{
            //    Console.WriteLine(games[userInput]);
            //}

            //How I would solve it
            try
            {
                Console.WriteLine(games[userInput]);
            } catch (Exception ex)
            {
                Console.WriteLine("Invalid number");
            }
        }   
    }
}
