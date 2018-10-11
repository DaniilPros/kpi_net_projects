using System;
using Lab1.Model;
using Lab1.Model.Factory;

namespace Lab1
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var worker = new Worker();
            worker.ParseFile("input.txt","output.html",new HtmlFactory());
            worker.ParseFile("input.txt","output.md",new MarkdownFactory());
        }
    }
}