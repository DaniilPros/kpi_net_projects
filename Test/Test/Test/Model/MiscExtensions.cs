using System;
using System.Collections.Generic;
using System.Linq;

namespace Test.Model
{
    public static class MiscExtensions
    {
        public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> source, int n)
        {
            if (source == null) throw new NullReferenceException();
            var enumerable = source.ToList();

            return enumerable.Skip(Math.Max(0, enumerable.Count() - n));
        }
    }
}