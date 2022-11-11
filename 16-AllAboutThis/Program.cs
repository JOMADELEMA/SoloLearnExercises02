using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _16_AllAboutThis
{
    internal class Program
    {
        /*
         * The program you are given takes 2 numbers as input
         * and should calculate and output their average. But
         * something is wrong. 
         * Complete the Avg class by creating the constructor, 
         * where the 2 parameters will be assigned to members of
         * the class. 
         * 
         * Sample input
         * 5.0
         * 4.0
         * 
         * sample output
         * 4.5
         */
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Avg avg = new Avg(num1, num2);

            Console.WriteLine(avg.GetAvg());
        }
        
        class Avg
        {
            double num1;
            double num2;

            public Avg(double num1, double num2)
            {
                this.num1 = num1;
                this.num2 = num2;
            }

            public double GetAvg()
            {
                return(num1+ num2)/2;
            }

        }
    }
}
