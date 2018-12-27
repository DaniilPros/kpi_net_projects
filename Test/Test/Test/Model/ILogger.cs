using System.Threading.Tasks;

namespace Test.Model
{
    public interface ILogger
    {
        Task InitializeAsync();
        void AddLog(InfoType infoType, string message);
        void OutputLastLog(int count);
    }
}