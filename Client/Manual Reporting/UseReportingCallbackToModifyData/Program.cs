using System;
using System.IO;
using OneTrueError.Reporting;

namespace UseReportingCallbackToModifyData
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OneTrue.Configuration.Credentials("874bda87-1489-4b11-9138-8de9d2110263",
                                              "3f5712b5-d487-40db-8750-422af3acf61e");

            OneTrue.Configuration.Advanced.AddCallback(new MyCallback());

            OneTrue.Report(
                new InvalidDataException(
                    "We don't need no stinking big data. https://twitter.com/wtrsld/status/424272437929205760/photo/1"));

            Console.ReadLine();
        }
    }
}