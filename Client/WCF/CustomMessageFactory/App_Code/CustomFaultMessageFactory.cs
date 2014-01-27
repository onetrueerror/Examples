using OneTrueError.Reporting.WCF;

namespace CustomMessageFactory
{
    public class CustomFaultMessageFactory : IErrorMessageFactory
    {
        public string Create(WcfErrorReporterContext context, string reportId)
        {
            var message = string.Format(@"You failed this application! 

You still have one chance left. Visit http://onetrueerror.com/feedback/{0}/ and make amends.", reportId);


            if (context.IncludeExceptionDetailInFaults)
                message += "\r\n\r\nError details: " + context.Exception;
            else if (context.IncludeExceptionMessageInFaults)
                message += "\r\n\r\nError reason: " + context.Exception.Message;

            return message;
        }
    }
}