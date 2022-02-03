using System;

namespace PatternObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Community com = new Community();
            Admin steve = new Admin("Steve");
            com.Subscribe(steve);
            Admin john = new Admin("John");
            com.Subscribe(john);
            Post post1 = new Post("New Post 1", "Text of post 1", john, com);
            User cyle = new User("Cyle");
            com.Subscribe(cyle);
            Post post2 = new Post("New Post 2", "Text of post 2", steve, com);

            Console.ReadKey();
        }   
    }
}
