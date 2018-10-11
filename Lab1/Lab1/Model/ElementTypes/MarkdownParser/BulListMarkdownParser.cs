using System;
using System.Collections.Generic;

namespace Lab1.Model.ElementTypes.MarkdownParser
{
    public class BulListMarkdownParser:IElementParser
    {
        public string ParseLines(List<string> lines)
        {
            lines.RemoveAt(0);
            var result = "";
            while (lines.Count>0&&!string.IsNullOrEmpty(lines[0]))
            {
                result += $"* {lines[0]} {Environment.NewLine}";
                lines.RemoveAt(0);
            }
            return $"{result}";
        }
    }
}