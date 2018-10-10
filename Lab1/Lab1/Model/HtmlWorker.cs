using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab1.Model
{
    public class HtmlWorker
    {
        private const string HtmlTemplate = @"<!DOCTYPE html>
                                            <html>
        <head>
        <title>Lab1 Proskurka Is 61</title>
        </head>
        <body>
        {0}
       </body>
        </html>";

        public void ParseFile(string fileName, string outFile)
        {
            var lines = File.ReadAllLines(fileName).ToList();

            var body = ParseLines(lines);

            File.WriteAllText(outFile, string.Format(HtmlTemplate, body));
        }

        private string ParseLines(List<string> lines)
        {
            var body = "";
            while (lines.Count > 0)
            {
                var elementParser = ParserFabric.GetParser(lines[0]);
                if (elementParser == null)
                {
                    lines.RemoveAt(0);
                    continue;
                }
                body += elementParser.ParseLines(lines);
            }

            return body;
        }
    }
}