using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_PasswordRules
{
    internal class Program
    {
        /*
         * You are creating an authentication system. 
         * The password shouldn't contain any of these symbols. 
         * 
         * !, #, $, %, &, (, ), *, +, -, ","
         * 
         * the given program takes the password as input. 
         * 
         * Task
         * Write a program to output "Invalid" if it contains any 
         * disallowed symbols. 
         * if the password requirement is satisfied, program 
         * shouldn't output anything. 
         * 
         * Sample input
         * yl1893!dm$
         * 
         * sample output
         * Invalid
         */
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };

            foreach(var symbol in notAllowedSymbols)
            {
                if (password.Contains(symbol))
                {
                    Console.WriteLine("Invalid");
                    break;
                }
            }
        }
    }
}
