using System;
using Lab1.Model;

namespace Lab1
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var worker = new HtmlWorker();
            worker.ParseFile("input.txt","output.html");
        }
    }
}