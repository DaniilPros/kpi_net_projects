using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lab1.Model.ElementTypes;
using Lab1.Model.ElementTypes.HtmlElements;
using Lab1.Model.Factory;

namespace Lab1.Model
{
    public class Worker
    {
       

        public void ParseFile(string fileName, string outFile,IParserFactory factory)
        {
            var lines = File.ReadAllLines(fileName).ToList();

            var body = ParseLines(lines,factory);

            File.WriteAllText(outFile, string.Format(factory.BasicTemplate, body));
        }

        private string ParseLines(List<string> lines,IParserFactory factory)
        {
            var body = "";
            while (lines.Count > 0)
            {
                var elementParser = GetParser(lines[0],factory);
                if (elementParser == null)
                {
                    lines.RemoveAt(0);
                    continue;
                }
                body += elementParser.ParseLines(lines);
            }

            return body;
        }
        private static IElementParser GetParser(string line,IParserFactory factory)
        {
            switch (line.Split(' ').FirstOrDefault())
            {
                case "p":
                    return factory.GetPParser();
                case "h1":
                    return factory.GetH1Parser();
                case "h2":
                    return factory.GetH2Parser();
                case "h3":
                    return factory.GetH3Parser();
                case "ordlist":
                    return factory.GetOrdListParser();
                case "bullist":
                    return factory.GetBulListParser();
                default:
                    return null;
            }
        }
    }
}