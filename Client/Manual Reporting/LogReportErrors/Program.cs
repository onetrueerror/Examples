using System;
using OneTrueError.Reporting;
using OneTrueError.Reporting.Submitters;

namespace LogReportErrors
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OneTrue.Configuration.Credentials("874bda87-1489-4b11-9138-8de9d2110263",
                                              "3f5712b5-d487-40db-8750-422af3acf61e");

            OneTrue.Report(new Exception("Hello world"));

            OneTrue.Configuration.Advanced.UploadReportFailed += OnReportFailed;

            //Required as reports are uploaded in the background.
            Console.ReadLine();
        }

        private static void OnReportFailed(object sender, UploadReportFailedEventArgs e)
        {
            if (e.Exception is InvalidApplicationKeyException)
            {
                Console.WriteLine(
                    "You specified an invalid app key. The report is still saved and will be uploaded when you have changed the appkey.");
            }
            if (e.Exception is UnauthorizedAccessException)
            {
                Console.WriteLine("Failed to authenticate using the sharedSecret. Did you specify it correctly?");
            }

            Console.WriteLine("All other errors is typically network errors etc.");
            Console.WriteLine(e.Exception);
        }
    }
}