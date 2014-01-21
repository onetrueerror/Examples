using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Manual_Reporting.Tools
{
    internal class DemoProvider
    {
        public static IEnumerable<ISample> GetDemos()
        {
            return from x in Assembly.GetExecutingAssembly().GetTypes()
                where typeof (ISample).IsAssignableFrom(x)
                      && !x.IsInterface
                select (ISample) Activator.CreateInstance(x);
        }
    }
}