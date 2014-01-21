#Custom submitter

You do not have to use our service but can only use the client libraries to get all context information etc to your own submitter. This example demonstrates how that work.

Start by creating a custom provider

```c#
    public class ReportToConsole : IErrorSubmitter
    {
        public void Submit(CreateErrorReportModel report)
        {
            Console.WriteLine(DateTime.Now + " " + JsonConvert.SerializeObject(report));
        }

        public string Id
        {
            get { return "ReportToConsole"; }
        }
    }
```

Which you then register in the provider:

```c#
OneTrue.Configuration.AddSubmitter(new ReportToConsole());
```

Then sit back and wait for an exception which will then result in the following:

![](./images/submitter.png?raw=true)


