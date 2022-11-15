using System;

namespace _05_SocialNetwork
{
    internal class Program
    {
        /*
         * You are making a social network application and want to add 
         * post creation functionality. 
         * As user creates a post, the next "New post" should be automatically
         * outputted so that then the user can add the text he/she wants to share. 
         * 
         * The program you are given declares a Post class with a text 
         * private field, and the ShoPost() method withi outputs the content. 
         * 
         * Complete the class with
         * - A constructor, which outputs "New post" as called, 
         * - Text property, which will allow you to get and set the value
         * of the text field. 
         * 
         * Once you have made the changes to the program so that it works 
         * correctly, then in main, the program will take the text of the post 
         * from the user, create a post object, assign the taken value to the 
         * text field and output it. 
         * 
         * Sample input: Hello!
         * Sample output: 
         * New Post
         * Hello!
         *              
         */
        static void Main(string[] args)
        {
            string PostText = Console.ReadLine();

            Post post = new Post();
            post.Text = PostText;
            post.ShowPost();
        }

        class Post
        {
            private string _text;
            public string Text
            {
                get { return _text; }
                set { _text = value; }
            }

            public Post() => Console.WriteLine("New post");

            public void ShowPost() => Console.WriteLine(Text);
        }
    }
}