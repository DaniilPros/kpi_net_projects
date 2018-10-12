

using Lab1.Framwork.Model.Parser;

namespace Lab1.Model.Factory
{
    public class HtmlFactory:BaseParserFactory
    {

        public override string BasicTemplate =>@"<!DOCTYPE html>
                                            <html>
        <head>
        <title>Lab1 Proskurka Is 61</title>
        </head>
        <body>
        {0}
       </body>
        </html>";

        public override BaseParser CreateParser()
        {
            return new HtmlParser();
        }
    }
}