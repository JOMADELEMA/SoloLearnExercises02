using System;

namespace _03_CreatingAProject
{
    internal class Program
    {
        /*
         * Your graphic application needs to report that a new 
         * project has been created successfully once the "Create"
         * button has been pressed. 
         * 
         * Complete the given class by adding a constructor that will show 
         * message "Prject created" once the operation is done. 
         */
        static void Main(string[] args)
        {
            Project project = new Project();
        }

        class Project
        {
            public Project() => Console.WriteLine("Project created");
        }
    }
}