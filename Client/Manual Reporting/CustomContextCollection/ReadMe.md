# Custom ContextCollection

This sample demonstrates how you can include custom context collections with the reports that are uploaded to our service.

Start by creating a collection provider

```c#
	class UserIdentityProvider : IContextInfoProvider
	{
		public ContextInfo Collect(IErrorReporterContext context)
		{
			var collection = new Dictionary<string, string> {{"AccountName", Environment.UserName}};
			return new ContextInfo("UserIdentity", collection);
		}
	}
```

Which you then register in the provider:

```c#
OneTrue.Configuration.AddContextProvider(new UserIdentityProvider());
```

Then sit back and wait for an exception which will then result in the following:

![](./images/screenshot.png?raw=true)


