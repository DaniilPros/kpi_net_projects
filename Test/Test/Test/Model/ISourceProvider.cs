using System.Collections.Generic;
using System.Threading.Tasks;

namespace Test.Model
{
    public interface ISourceProvider
    {
        string ConnectionString { get; }
    }
}