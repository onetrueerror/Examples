#Library errors

When you get started it can be a good idea to print out errors from the OneTrueError library. 

This is done by hooking an event:

```c#
OneTrue.Configuration.Advanced.UploadReportFailed += OnReportFailed;
```

And then just print the errors:

```c#
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
```

