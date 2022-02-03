using System;
using System.Collections.Generic;
using System.Text;

namespace PatternObserver
{
    class Post
    {
        public string Title { get; }
        public string Text { get; }
        public Admin Author { get; }
        public Post(string title, string text, Admin author, IObservable<Post> community)
        {
            Title = title;
            Text = text;
            Author = author;
            community.Notify(this);
        }
    }
}
