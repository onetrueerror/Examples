using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OneTrueError.Reporting;

namespace CustomErrorReportId
{
    class Program
    {
        static void Main(string[] args)
        {
            OneTrue.Configuration.Credentials("874bda87-1489-4b11-9138-8de9d2110263",
                                              "3f5712b5-d487-40db-8750-422af3acf61e");

            ReportIdGenerator.Assign(CustomIdGenerator);

            // and the reporting here.
        }

        private static string CustomIdGenerator(Exception exception)
        {
            var guid = Guid.NewGuid().ToString();
            var buffer = Encoding.ASCII.GetBytes(guid);
            return Convert.ToBase64String(buffer);
        }
    }
}
