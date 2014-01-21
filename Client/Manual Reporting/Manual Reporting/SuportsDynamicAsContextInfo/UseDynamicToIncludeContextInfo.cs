using System;
using Manual_Reporting.Tools;
using OneTrueError.Reporting;

namespace Manual_Reporting.SuportsDynamicAsContextInfo
{
    public class UseDynamicToIncludeContextInfo : ISample
    {
        private UserRepository _repository = new UserRepository();

        public string Name
        {
            get { return "Dynamic"; }
        }

        public string Description
        {
            get { return "Shows how to include a context information by using an anonymous object."; }
        }

        public void Execute()
        {
            Execute("arne", DateTime.UtcNow);
        }

        private void Execute(string userName, DateTime createdAtUtc)
        {
            try
            {
                _repository.Create(userName, createdAtUtc);
            }
            catch (Exception exception)
            {
                // Normally we would not catch exceptions just to report them. Instead we would use
                // one of the OTE framework libraries to catch unhandled exceptions in the top layer.
                //
                // It gives much cleaner code. This sample just do this as an demonstration.
                //
                // the object could be any combination of "real" classes and anonymous objects
                OneTrue.Report(exception, new {userName, createdAtUtc});
            }
        }
    }
}