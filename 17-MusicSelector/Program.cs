using System;

namespace _17_MusicSelector
{
    internal class Program
    {
        /*
         * The music app you enjoy allows you to choose 5 music 
         * genres to follow. 
         * The program you are given takes 5 music genres as
         * input and stores them in the MusicGenres object as an 
         * array. 
         * Fix the program by declaring an indexer inside the 
         * MusicGenres class so that the given outputs work 
         * correctly. 
         * 
         * Sample input
         * Blues 
         * Rock
         * Hip Hop
         * Country
         * Soul
         * 
         * Sample Output:
         * Following: Blues
         * Following: Rock
         * Following: Hip Hop
         * Following: Country
         * Following: Soul
         */
        static void Main(string[] args)
        {
            MusicGenres genres = new MusicGenres();

            int count = 0;
            while(count<5)
            {
                genres[count] = Console.ReadLine();
                count++;
            }

            for(int i = 0; i < 5; i++)
                Console.WriteLine("Following: " + genres[i]);
        }

        class MusicGenres
        {
            private string[] _genres = new string[5];

            public string this[int index]
            {
                get { return _genres[index]; }
                set
                {
                    _genres[index] = value;  
                }
            }
        }
    }
}