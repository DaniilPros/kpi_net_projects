using System;

namespace Lab3
{
    internal class Person : ISubscriber
    {
        public string Name { get; set; }

        public Person(string name) => Name = name;

        public void ReceiveItem() => Console.WriteLine(Name + " has received newspaper!");
    }
}