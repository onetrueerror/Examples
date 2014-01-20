using System;
using OneTrueError.Reporting;

namespace Manual_Reporting.BasicExample
{
    internal class SimpleSample : ISample
    {
        public string Name
        {
            get { return "Basic"; }
        }

        public string Description
        {
            get { return "Demonstrates the most basic approach to reporting."; }
        }

        public void Execute()
        {
            try
            {
                var x = 1;
                var y = 0;

                // ohh, why?
                Console.WriteLine(x/y);
            }
            catch (Exception exception)
            {
                OneTrue.Report(exception);
            }
        }
    }
}