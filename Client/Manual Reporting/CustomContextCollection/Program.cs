using System;
using OneTrueError.Reporting;
using OneTrueError.Reporting.Submitters;

namespace CustomContextCollection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Will include the user identity in all reports.
            OneTrue.Configuration.AddContextProvider(new UserIdentityProvider());

            OneTrue.Configuration.Credentials("874bda87-1489-4b11-9138-8de9d2110263",
                                              "3f5712b5-d487-40db-8750-422af3acf61e");

            OneTrue.Report(new Exception("With credentials"));

            //Required as reports are uploaded in the background.
            Console.ReadLine();
        }
    }
}