using Lab1.Model.ElementTypes;
using Lab1.Model.ElementTypes.HtmlElements;

namespace Lab1.Model.Factory
{
    public class HtmlFactory:IParserFactory
    {
        public IElementParser GetPParser()
        {
            return new PHtmlParser();
        }

        public IElementParser GetH1Parser()
        {
            return new H1HtmlParser();
        }

        public IElementParser GetH2Parser()
        {
            return new H2HtmlParser();
        }

        public IElementParser GetH3Parser()
        {
           return new H3HtmlParser();
        }

        public IElementParser GetOrdListParser()
        {
            return new OrdListHtmlParser();
        }

        public IElementParser GetBulListParser()
        {
            return new BulListHtmlParser();
        }

        public string BasicTemplate =>@"<!DOCTYPE html>
                                            <html>
        <head>
        <title>Lab1 Proskurka Is 61</title>
        </head>
        <body>
        {0}
       </body>
        </html>";
    }
}