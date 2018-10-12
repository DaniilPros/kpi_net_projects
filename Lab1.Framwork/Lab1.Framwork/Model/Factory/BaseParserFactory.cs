using Lab1.Framwork.Model.Parser;

namespace Lab1.Model.Factory
{
    public abstract class BaseParserFactory
    {
        public abstract BaseParser CreateParser();
        public abstract string BasicTemplate { get; }
    }
}