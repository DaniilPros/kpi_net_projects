using System;

namespace Test.Model
{
    public enum InfoType
    {
        Info,
        Warning,
        Error
    }
    public class LogItem
    {
        public DateTimeOffset Time { get; set; }
        public string Message { get; set; }
        public InfoType InfoType { get; set; }
        public override string ToString() => $"{Time:G}; type: {InfoType}; message: {Message}";
    }
}