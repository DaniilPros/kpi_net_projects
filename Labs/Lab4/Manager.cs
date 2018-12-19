using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public class Manager
    {
        public List<Storage> Storages { get; } = new List<Storage>();
        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var storage in Storages)
                sb.AppendLine(storage + Environment.NewLine);

            return sb.ToString();
        }
    }
}