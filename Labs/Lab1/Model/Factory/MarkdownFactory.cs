using Lab1.Framwork.Model.Parser;

namespace Lab1.Model.Factory
{
    public class MarkdownFactory : BaseParserFactory
    {


        public override string BasicTemplate => "{0}";

        public override BaseParser CreateParser()
        {
            return new MarkdownParser();

        }
    }
}