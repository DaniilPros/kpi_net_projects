using System;

namespace Lab3
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var postOffice = new Post();
            postOffice.Subscribe(new Person("Person1"));
            postOffice.Subscribe(new Person("Person2"));
            postOffice.Subscribe(new Person("Person3"));

            var publisher = new Publisher();
            publisher.SubscribePost(postOffice);
            publisher.Publish();
             
            postOffice.UnsubscribeAll();
            
            Console.ReadKey();
        }
    }
}