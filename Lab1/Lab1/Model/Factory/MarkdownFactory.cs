using Lab1.Model.ElementTypes;
using Lab1.Model.ElementTypes.HtmlElements;
using Lab1.Model.ElementTypes.MarkdownParser;

namespace Lab1.Model.Factory
{
    public class MarkdownFactory : IParserFactory
    {
        public IElementParser GetPParser()
        {
            return new PMarkdownParser();
        }

        public IElementParser GetH1Parser()
        {
            return new H1MarkdownParser();
        }

        public IElementParser GetH2Parser()
        {
            return new H2MarkdownParser();
        }

        public IElementParser GetH3Parser()
        {
            return new H3MarkdownParser();
        }

        public IElementParser GetOrdListParser()
        {
            return new OrdListMarkdownParser();
        }

        public IElementParser GetBulListParser()
        {
            return new BulListMarkdownParser();
        }

        public string BasicTemplate => "{0}";
    }
}