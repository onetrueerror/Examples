using System;
using System.Collections.Generic;
using System.Threading;
using OneTrueError.Reporting.ContextProviders;
using OneTrueError.Reporting.Contracts;
using OneTrueError.Reporting.Reporters;

namespace CustomContextCollection
{
internal class UserIdentityProvider : IContextInfoProvider
{
    public ContextInfo Collect(IErrorReporterContext context)
    {
        var collection = new Dictionary<string, string> {{"AccountName", Environment.UserName}};
        return new ContextInfo("UserIdentity", collection);
    }
}
}