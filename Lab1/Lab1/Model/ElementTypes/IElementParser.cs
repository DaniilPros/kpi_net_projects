using System.Collections.Generic;

namespace Lab1.Model.ElementTypes
{
    public interface IElementParser
    {
        string ParseLines(List<string> lines);
    }
}