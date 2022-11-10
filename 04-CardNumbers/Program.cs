using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CardNumbers
{
    internal class Program
    {
        /*
         * The program you are given should output the account
         * number on the bank card. 
         * But something is wrong. 
         * Create a get property to access the corresponding class 
         * member and also fix the output. 
         */
        static void Main(string[] args)
        {
            Card card1 = new Card();
            Console.WriteLine(card1.AccountNum);
        }

        class Card
        {
            private string accountNum = "0011592048120";

            public string AccountNum
            {
                get { return accountNum; }
            }
        }
    }
}
