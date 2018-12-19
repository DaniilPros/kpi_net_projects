using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public class Storage
    {
        public string Name { get; set; }
        public List<Item> Items { get; } = new List<Item>();
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Storage: {Name}");
            foreach (var item in Items)
                sb.AppendLine(item.ToString());

            return sb.ToString();
        }
    }
}