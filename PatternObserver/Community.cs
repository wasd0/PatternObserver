using System;
using System.Collections.Generic;
using System.Text;

namespace PatternObserver
{
    class Community : IObservable<Post>
    {
        private readonly List<IObserver<Post>> _members;
        public Community()
        {
            _members = new List<IObserver<Post>>();
        }
        public void Notify(Post data)
        {
            foreach (var member in _members) member.Update(data);
        }

        public void Subscribe(IObserver<Post> observer)
        {
            if (!_members.Contains(observer)) _members.Add(observer);
        }

        public void Unsubscribe(IObserver<Post> observer)
        {
            _members.Remove(observer);
        }
    }
}
