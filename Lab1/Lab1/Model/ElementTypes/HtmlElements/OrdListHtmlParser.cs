using System.Collections.Generic;

namespace Lab1.Model.ElementTypes.HtmlElements
{
    public class OrdListHtmlParser:IElementParser
    {
        public string ParseLines(List<string> lines)
        {
            lines.RemoveAt(0);
            var result = "";
            while (lines.Count>0&&!string.IsNullOrEmpty(lines[0]))
            {
                result += $"<li>{lines[0]}</li>";
                lines.RemoveAt(0);
            }
            return $"<ul>{result}</ul>";
        }
    }
}