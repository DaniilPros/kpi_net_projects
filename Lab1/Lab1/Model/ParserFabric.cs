using System.Linq;
using Lab1.Model.ElementTypes;

namespace Lab1.Model
{
    public class ParserFabric
    {
        public static IElementParser GetParser(string line)
        {
            switch (line.Split(' ').FirstOrDefault())
            {
                case "p":
                    return new PParser();
                case "h1":
                    return new H1Parser();
                case "h2":
                    return new H2Parser();
                case "h3":
                    return new H3Parser();
                case "ordlist":
                    return new OrdListParser();
                case "bullist":
                    return new BulListParser();
                default:
                    return null;
            }
        }
    }
}