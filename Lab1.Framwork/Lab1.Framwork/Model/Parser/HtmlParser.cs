using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Framwork.Model.Parser
{
    internal class HtmlParser : BaseParser
    {
        public override string PraseBulListElement(List<string> lines)
        {
            lines.RemoveAt(0);
            var result = "";
            while (lines.Count > 0 && !string.IsNullOrEmpty(lines[0]))
            {
                result += $"<li>{lines[0]}</li>";
                lines.RemoveAt(0);
            }
            return $"<ol>{result}</ol>";
        }

        public override string ParseH1Element(List<string> lines)
        {
            var strings = lines[0].Split(' ').ToList();
            strings.RemoveAt(0);

            lines.RemoveAt(0);
            var result = strings.Aggregate((i, res) => res = i + " " + res) + "<br>";
            while (lines.Count > 0 && !string.IsNullOrEmpty(lines[0]))
            {
                result += $"{lines[0]}<br>";
                lines.RemoveAt(0);
            }
            return $"<h1>{result}</h1>";
        }

        public override string PraseH2Element(List<string> lines)
        {
            var strings = lines[0].Split(' ').ToList();
            strings.RemoveAt(0);

            lines.RemoveAt(0);
            var result = strings.Aggregate((i, res) => res = i + " " + res) + "<br>";
            while (lines.Count > 0 && !string.IsNullOrEmpty(lines[0]))
            {
                result += $"{lines[0]}<br>";
                lines.RemoveAt(0);
            }
            return $"<h2>{result}</h2>";
        }

        public override string PraseH3Element(List<string> lines)
        {
            var strings = lines[0].Split(' ').ToList();
            strings.RemoveAt(0);

            lines.RemoveAt(0);
            var result = strings.Aggregate((i, res) => res = i + " " + res) + "<br>";
            while (lines.Count > 0 && !string.IsNullOrEmpty(lines[0]))
            {
                result += $"{lines[0]}<br>";
                lines.RemoveAt(0);
            }
            return $"<h3>{result}</h3>";
        }

        public override string PraseOrdListElement(List<string> lines)
        {
            lines.RemoveAt(0);
            var result = "";
            while (lines.Count > 0 && !string.IsNullOrEmpty(lines[0]))
            {
                result += $"<li>{lines[0]}</li>";
                lines.RemoveAt(0);
            }
            return $"<ul>{result}</ul>";
        }

        public override string PrasePElement(List<string> lines)
        {
            var strings = lines[0].Split(' ').ToList();
            strings.RemoveAt(0);

            lines.RemoveAt(0);
            var result = strings.Aggregate((i, res) => res = i + " " + res) + "<br>";
            while (lines.Count > 0 && !string.IsNullOrEmpty(lines[0]))
            {
                result += $"{lines[0]}<br>";
                lines.RemoveAt(0);
            }
            return $"<p>{result}</p>";
        }
    }
}
