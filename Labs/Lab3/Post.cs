using System;
using System.Collections.Generic;

namespace Lab3
{
    internal class Post
    {
        private readonly List<ISubscriber> _subscribers = new List<ISubscriber>();

        public void Receive()
        {
            foreach (var subscriber in _subscribers)
                subscriber.ReceiveItem();
        }

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
            Console.WriteLine($"{subscriber.Name} subscribed");
        }

        public void UnsubscribeAll()
        {
            var arr = new ISubscriber[_subscribers.Count];
            _subscribers.CopyTo(arr);
            foreach (var subscriber in arr)
                Unsubscribe(subscriber);
        }

        private void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
            Console.WriteLine($"{subscriber.Name} unsubscribed");
        }
    }
}