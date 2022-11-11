using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Dance
{
    internal class Program
    {
        /*
         * In a ballroom dancing competition, each dancer from a 
         * pair is evaluated separately, and then rheir points are
         * summed up to get the total pair score. 
         * The progra you are given takes the names and the points
         * of each dancer as input and creates a DancerPoints 
         * objects for each dancer, using the taken name and score values
         * as parameters for constructors. 
         * Complete the given class, using overload + operator to 
         * return a new object where the names of dancers are 
         * in one string (see sample output) and the score is equal to the sum of their points. 
         * The declaration of that object and the output of its 
         * points are already written in Main()
         * 
         * Sample input
         * Dave
         * 8
         * Jessica
         * 7
         * 
         * Sample output 
         * Dave & Jessica
         * 15
         * 
         */
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);

        }

        class DancerPoints
        {
            public string name;
            public int points;
            public DancerPoints(string name, int points)
            {
                this.name = name;
                this.points = points;
            }

            public static DancerPoints operator+ (DancerPoints dp1, DancerPoints dp2)
            {
                string newName = dp1.name + " & " + dp2.name;
                int pointsSum = dp1.points + dp2.points;

                return new DancerPoints(newName, pointsSum);
            }

        }
    }
}
