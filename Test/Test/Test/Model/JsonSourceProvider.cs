namespace Test.Model
{
    public class JsonSourceProvider : ISourceProvider
    {
        public string ConnectionString { get; }

        public JsonSourceProvider(string path)
        {
            ConnectionString = path;
        }
    }
}