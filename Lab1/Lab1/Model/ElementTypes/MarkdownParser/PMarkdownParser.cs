using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1.Model.ElementTypes.MarkdownParser
{
    public class PMarkdownParser : IElementParser
    {
        public string ParseLines(List<string> lines)
        {
            var strings = lines[0].Split(' ').ToList();
            strings.RemoveAt(0);
            
            lines.RemoveAt(0);
            var result = strings.Aggregate((i, res) => res = i + " " + res) + Environment.NewLine;
            while (lines.Count>0&&!string.IsNullOrEmpty(lines[0]))
            {
                result += $"{lines[0]}{Environment.NewLine}";
                lines.RemoveAt(0);
            }
            return $"{result}";
        }
    }
}