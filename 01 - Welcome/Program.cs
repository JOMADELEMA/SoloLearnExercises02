using System;

namespace _01___Welcome
{
    internal class Program
    {
        /*
         * Define a class Welcome which has one public method
         * called WelcomeMessage(), and should print "Welcome to OOP" when called. 
         */
        static void Main(string[] args)
        {
            Welcome welcome = new Welcome();
            welcome.WelcomeMessage();
        }

        public class Welcome
        {
            public void WelcomeMessage() => Console.WriteLine("Welcome to OOP");
        }
    }
}