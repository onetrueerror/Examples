using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using OneTrueError.Reporting.WCF;

namespace EasiestSetup
{
    [OneTrueErrorHandler]
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            throw new StackOverflowException("Too plenty dollas");
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
