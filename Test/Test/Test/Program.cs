using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Test.Model;

namespace Test
{
    class Program
    {
        private static async Task Main(string[] args)
        {
            var program = new Program();

            await program.InitAsync();
            program.DoWork();


            program.WaitForKey(ConsoleKey.Escape);

        }

        private async Task InitAsync()
        {
            await _logger.InitializeAsync();

        }

        private Random _random = new Random();
        private readonly ILogger _logger = new Logger(new JsonSourceProvider("log.txt"));
        public void WaitForKey(ConsoleKey key)
        {
            do
            {
                Console.WriteLine($"\nPress {key} to continue");
            } while (Console.ReadKey().Key != key);


        }

        public void DoWork()
        {
            _logger.OutputLastLog(100);
            GenerateRandomLogs(100);
            _logger.OutputLastLog(10);
            GenerateRandomLogs(5);
            _logger.OutputLastLog(10);
        }

        public void GenerateRandomLogs(int count)
        {
            for (var i = 0; i < count; i++)
                _logger.AddLog((InfoType)(_random.Next(3)), $"Random message {_random.Next(345)}");
            Console.WriteLine($"\nAdded {count} random logs");
        }
    }
}
