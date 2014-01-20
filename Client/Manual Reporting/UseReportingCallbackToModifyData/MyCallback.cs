using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OneTrueError.Reporting;
using OneTrueError.Reporting.Contracts;

namespace UseReportingCallbackToModifyData
{
    public class MyCallback : IErrorCallback
    {
        private Random _random = new Random();

        public void Trigger(ErrorCallbackContext context)
        {
            // don't send all reports, just for fun.
            context.CanSubmitReport = _random.Next(2) == 1;


            // simple example of how you can modify the context information.
            var reports = context.Report.ContextCollections.ToList();
            var collection = new Dictionary<string, string> { { "User", Environment.UserName } };
            var identityContext = new ContextInfo("UserIdentity", collection);
            reports.Add(identityContext);
            context.Report.ContextCollections = reports.ToArray();
        }
    }
}