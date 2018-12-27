using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Test.Model
{
    public class Logger : ILogger
    {

        private List<LogItem> _logItems;

        private readonly ISourceProvider _sourceProvider;

        public Logger(ISourceProvider sourceProvider)
        {
            _sourceProvider = sourceProvider;
            _init = InitInternal();
        }

        private readonly Task _init;

        private async Task InitInternal()
        {
            await Task.Run(() =>
            {
                _logItems = new List<LogItem>();
                if (!File.Exists(_sourceProvider.ConnectionString)) return;
                var lines = File.ReadAllLines(_sourceProvider.ConnectionString);
                foreach (var line in lines)
                {
                    var logItem = JsonConvert.DeserializeObject<LogItem>(line);
                    _logItems.Add(logItem);
                }

            });

        }

        public async Task InitializeAsync()
        {
            await _init;
        }

        public void AddLog(InfoType infoType, string message)
        {
            var logItem = new LogItem()
            {
                Time = DateTimeOffset.UtcNow,
                Message = message,
                InfoType = infoType
            };

            _logItems.Add(logItem);
            File.AppendAllText(_sourceProvider.ConnectionString, JsonConvert.SerializeObject(logItem) + Environment.NewLine);
        }

        public void OutputLastLog(int count)
        {
            Console.WriteLine($"\nOutput {count} logs");
            foreach (var logItem in _logItems.TakeLast(count))
                Console.WriteLine(logItem);
            Console.WriteLine("");
        }
    }
}