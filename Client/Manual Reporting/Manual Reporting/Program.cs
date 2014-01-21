using System;
using System.Linq;
using Manual_Reporting.Tools;
using OneTrueError.Reporting;

namespace Manual_Reporting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OneTrue.Configuration.Credentials("874bda87-1489-4b11-9138-8de9d2110263",
                                              "3f5712b5-d487-40db-8750-422af3acf61e");

            var demos = DemoProvider.GetDemos();
            Console.WriteLine("Demo application.");
            Console.WriteLine("=====================");
            while (true)
            {
                Console.WriteLine();
                foreach (var demo in demos)
                {
                    Console.WriteLine(demo.Name.PadRight(20) + demo.Description);
                }
                Console.WriteLine();
                Console.Write("Enter the name of the demo to run: ");

                var name = Console.ReadLine();
                var selected = demos.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (selected == null)
                {
                    Console.WriteLine("Incorrect name");
                    break;
                }

                selected.Execute();
                Console.WriteLine();
                Console.WriteLine("Demo executed.");
                Console.WriteLine("Log into http://onetrueerror.com with demo/demo to see the result.");
            }
        }
    }
}