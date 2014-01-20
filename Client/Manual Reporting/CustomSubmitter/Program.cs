using System;
using OneTrueError.Reporting;

namespace CustomSubmitter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OneTrue.Configuration.AddSubmitter(new ReportToConsole());

            OneTrue.Report(new Exception("Hello world"));


            Console.ReadLine();
        }
    }
}