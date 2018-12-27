using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var manager = new Manager();
            CreateTestData(manager);

            Console.WriteLine("Storages:");
            Console.WriteLine(manager);

            Console.WriteLine(Environment.NewLine + "Task1:");
            Console.WriteLine("Get all items, sorted by date");
            var items1 = manager.Storages.Aggregate(new List<Item>(), (r, c) => r.Concat(c.Items).ToList());
            items1.Sort(new DateComparer());
            foreach (var item in items1)
                Console.WriteLine(item);


            Console.WriteLine(Environment.NewLine + "Task2:");
            Console.WriteLine("Get items grouped by fabric name");
            var items2 = manager.Storages.Aggregate(new List<Item>(), (r, c) => r.Concat(c.Items).ToList())
                .GroupBy(i=>i.FabricName,i=>i,(key,g)=>new {Fabric = key,Items = g.ToList()});
            foreach (var x1 in items2)
            {
                Console.WriteLine(x1.Fabric);
                foreach (var item in x1.Items)
                    Console.WriteLine($"\t{item}");
            }


            Console.WriteLine(Environment.NewLine + "Task3:");
            Console.WriteLine("Get items grouped by fabric name, sorted by price");
            var items3 = manager.Storages.Aggregate(new List<Item>(), (r, c) => r.Concat(c.Items).ToList())
                .GroupBy(i => i.FabricName, i => i, (key, g) => new { Fabric = key, Items = g.ToList() });
            foreach (var x1 in items3)
            {
                Console.WriteLine(x1.Fabric);
                x1.Items.Sort(new PriceComparer());
                foreach (var item in x1.Items)
                    Console.WriteLine($"\t{item}");
            }

            Console.WriteLine(Environment.NewLine + "Task4:");
            Console.WriteLine("Get all items where price is more than 10");
            var items4 = manager.Storages.Aggregate(new List<Item>(), (r, c) => r.Concat(c.Items).ToList())
                .Where(item=>item.Price>10);
            foreach (var item in items4)
                Console.WriteLine(item);

            Console.WriteLine(Environment.NewLine + "Task5:");
            Console.WriteLine("Get all items where count is more than 2, sorted by date");
            var items5 = manager.Storages.Aggregate(new List<Item>(), (r, c) => r.Concat(c.Items).ToList())
                .Where(item => item.Count > 2);
            items1.Sort(new DateComparer());
            foreach (var item in items5)
                Console.WriteLine(item);

            Console.WriteLine(Environment.NewLine + "Task6:");
            Console.WriteLine("Get sum of prices grouped by fabric name");
            var items6 = manager.Storages.Aggregate(new List<Item>(), (r, c) => r.Concat(c.Items).ToList()).GroupBy(i => i.FabricName, i => i.Price*i.Count, (key, g) => new { Fabric = key, Sum = g.Sum() });
            foreach (var x1 in items6)
                Console.WriteLine($"Fabric: {x1.Fabric}, sum: {x1.Sum}");


            Console.WriteLine(Environment.NewLine + "Task7:");
            Console.WriteLine("Get sum of prices grouped by day of week");
            var items7 = manager.Storages.Aggregate(new List<Item>(), (r, c) => r.Concat(c.Items).ToList())
                .GroupBy(i => i.Time.DayOfWeek, i => i.Price * i.Count, (key, g) => new { Time = key, Sum = g.Sum() });
            foreach (var x1 in items7)
                Console.WriteLine($"Fabric: {x1.Time}, sum: {x1.Sum}");


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }

        private static void CreateTestData(Manager manager)
        {

            var storage1 = new Storage { Name = "Storage1" };
            var storage2 = new Storage { Name = "Storage2" };
            var storage3 = new Storage { Name = "Storage3" };

            storage1.Items.Add(new Item()
            {
                Name = "Item1",
                Count = 3,
                Price = 56,
                FabricName = "Fabric1",
                Time = DateTime.Now-TimeSpan.FromDays(3)
            });

            storage1.Items.Add(new Item()
            {
                Name = "Item2",
                Count = 1,
                Price = 32,
                FabricName = "Fabric2",
                Time = DateTime.Now - TimeSpan.FromDays(6)
            });

            storage1.Items.Add(new Item()
            {
                Name = "Item3",
                Count = 4,
                Price = 45,
                FabricName = "Fabric1",
                Time = DateTime.Now - TimeSpan.FromDays(1)
            });

            storage2.Items.Add(new Item()
            {
                Name = "Item4",
                Count = 3,
                Price = 6,
                FabricName = "Fabric1",
                Time = DateTime.Now - TimeSpan.FromDays(2)
            });

            storage2.Items.Add(new Item()
            {
                Name = "Item5",
                Count = 1,
                Price = 52,
                FabricName = "Fabric4",
                Time = DateTime.Now - TimeSpan.FromDays(5)
            });

            storage2.Items.Add(new Item()
            {
                Name = "Item6",
                Count = 4,
                Price = 35,
                FabricName = "Fabric3",
                Time = DateTime.Now - TimeSpan.FromDays(2)
            });

            storage3.Items.Add(new Item()
            {
                Name = "Item7",
                Count = 2,
                Price = 5,
                FabricName = "Fabric4",
                Time = DateTime.Now - TimeSpan.FromDays(5)
            });

            storage3.Items.Add(new Item()
            {
                Name = "Item8",
                Count = 5,
                Price = 2,
                FabricName = "Fabric2",
                Time = DateTime.Now - TimeSpan.FromDays(2)
            });

            storage3.Items.Add(new Item()
            {
                Name = "Item9",
                Count = 3,
                Price = 4,
                FabricName = "Fabric3",
                Time = DateTime.Now - TimeSpan.FromDays(3)
            });

            manager.Storages.Add(storage1);
            manager.Storages.Add(storage2);
            manager.Storages.Add(storage3);
        }
    }
}
