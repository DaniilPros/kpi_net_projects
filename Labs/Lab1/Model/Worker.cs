using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lab1.Framwork.Model.Parser;
using Lab1.Model.Factory;

namespace Lab1.Model
{
    public class Worker
    {


        public void ParseFile(string fileName, string outFile, BaseParserFactory factory)
        {
            var lines = File.ReadAllLines(fileName).ToList();

            var body = ParseLines(lines, factory.CreateParser());

            File.WriteAllText(outFile, string.Format(factory.BasicTemplate, body));
        }

        private string ParseLines(List<string> lines, BaseParser parser)
        {
            var body = "";

            while (lines.Count > 0)
            {
                var result = GetParser(lines, parser);
                if (result == null)
                {
                    lines.RemoveAt(0);
                    continue;
                }
                body += result;
            }

            return body;
        }
        private static string GetParser(List<string> lines, BaseParser parser)
        {
            switch (lines[0].Split(' ').FirstOrDefault())
            {
                case "p":
                    return parser.PrasePElement(lines);
                case "h1":
                    return parser.ParseH1Element(lines);
                case "h2":
                    return parser.PraseH2Element(lines);
                case "h3":
                    return parser.PraseH3Element(lines);
                case "ordlist":
                    return parser.PraseOrdListElement(lines);
                case "bullist":
                    return parser.PraseBulListElement(lines);
                default:
                    return null;
            }
        }
    }
}