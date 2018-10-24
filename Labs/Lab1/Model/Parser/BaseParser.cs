using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Framwork.Model.Parser
{
    public abstract class BaseParser
    {
        public abstract string PrasePElement(List<string> lines);
        public abstract string ParseH1Element(List<string> lines);
        public abstract string PraseH2Element(List<string> lines);
        public abstract string PraseH3Element(List<string> lines);
        public abstract string PraseOrdListElement(List<string> lines);
        public abstract string PraseBulListElement(List<string> lines);

    }
}
