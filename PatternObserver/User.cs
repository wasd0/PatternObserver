using System;
using System.Collections.Generic;
using System.Text;

namespace PatternObserver
{
    class User : IObserver<Post>
    {
        public string Name { get; }
        public User(string name)
        {
            Name = name;
        }
        public void Update(Post post)
        {
            Console.WriteLine(Name);
            Console.WriteLine(new String('_', 40));
            Console.WriteLine(post.Title);
            Console.WriteLine(post.Text);
            Console.WriteLine("Author: {0}", post.Author.Name);
            Console.WriteLine("Time: " + DateTime.Now);
            Console.WriteLine(new String('_', 40));

        }
    }
}
