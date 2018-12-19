using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab4
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public long Count { get; set; }
        public DateTime Time { get; set; }
        public string FabricName { get; set; }
        public override string ToString() => $"Item: {Name}, Price: {Price}, Count: {Count}, Time: {Time}, FabricName: {FabricName}";
    }

    public class DateComparer:IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            Debug.Assert(x != null, nameof(x) + " != null");
            Debug.Assert(y != null, nameof(y) + " != null");
            if (x.Time > y.Time) return 1;
            return x.Time < y.Time ? -1 : 0;
        }
    }

    public class PriceComparer : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            Debug.Assert(x != null, nameof(x) + " != null");
            Debug.Assert(y != null, nameof(y) + " != null");
            if (x.Price > y.Price) return 1;
            return x.Price < y.Price ? -1 : 0;
        }
    }
}