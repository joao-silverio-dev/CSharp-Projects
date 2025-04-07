using System;
using Exercicio03.Entities;

namespace Exercicio03
{
    public class Program
    {
        public Program()
        {
            Comment c1 = new Comment("Have a Nice Trip");
            Comment c2 = new Comment("Wow that's awesome");
            Post post1 = new Post(
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12,
                DateTime.Parse("21/06/2018 13:05:44")
            );
            post1.AddComment(c1);
            post1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");
            Post post2 = new Post(
                "Good night guys",
                "See you tomorrow",
                5,
                DateTime.Parse("28/07/2018 23:14:19")
            );
            post2.AddComment(c3);
            post2.AddComment(c4);
            
            Console.WriteLine(post1);
            Console.WriteLine(post2);

        }
        public static void Main(string[] args)
        {
            new Program();
        }
    }
}