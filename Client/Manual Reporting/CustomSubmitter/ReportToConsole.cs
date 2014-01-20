using System;
using Newtonsoft.Json;
using OneTrueError.Reporting.Contracts;
using OneTrueError.Reporting.Submitters;

namespace CustomSubmitter
{
    /// <summary>
    ///     shows how you can add a custom submitter which will receive all reports.
    /// </summary>
    public class ReportToConsole : IErrorSubmitter
    {
        public void Submit(CreateErrorReportModel report)
        {
            Console.WriteLine(DateTime.Now + " " + JsonConvert.SerializeObject(report));
        }

        /// <summary>
        ///     Id must be considered to be a const and may not changed once returned.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         Used to store reports on disk until they can be uploaded
        ///     </para>
        /// </remarks>
        public string Id
        {
            get { return "CustomConsoleSubmitter"; }
        }
    }
}