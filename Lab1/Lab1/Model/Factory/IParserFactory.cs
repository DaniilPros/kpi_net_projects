using Lab1.Model.ElementTypes;

namespace Lab1.Model.Factory
{
    public interface IParserFactory
    {
        IElementParser GetPParser();
        IElementParser GetH1Parser();
        IElementParser GetH2Parser();
        IElementParser GetH3Parser();
        IElementParser GetOrdListParser();
        IElementParser GetBulListParser();
        string BasicTemplate { get; }
    }
}