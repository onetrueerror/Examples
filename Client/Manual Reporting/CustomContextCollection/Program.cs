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

            //OneTrue.Configuration.Credentials("874bda87-1489-4b11-9138-8de9d2110263",
            //                                  "3f5712b5-d487-40db-8750-422af3acf61e");

            OneTrue.Configuration.AddSubmitter(new ReportToOneTrueError("5b667d8b-5368-4f82-8e39-eaa3c0b06728",
                "ef87188e-676a-4c76-a8f9-931fd4915aca")
            {
                RemoteHost = "http://report-beta.onetrueerror.com"
            });


            OneTrue.Report(new Exception("With credentials"));

            //Required as reports are uploaded in the background.
            Console.ReadLine();
        }
    }
}