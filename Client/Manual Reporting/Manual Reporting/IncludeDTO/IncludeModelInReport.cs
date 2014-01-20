using System;
using OneTrueError.Reporting;

namespace Manual_Reporting.IncludeDTO
{
    public class IncludeModelInReport : ISample
    {
        private UserRepository _repository = new UserRepository();

        public string Name
        {
            get { return "DTO"; }
        }

        public string Description
        {
            get { return "Shows how to include a view model or DTO in the error report."; }
        }

        public void Execute()
        {
            var model = new UserEntity();
            model.Id = Guid.NewGuid().ToString();
            model.CreatedAtUtc = DateTime.UtcNow;
            Execute(model);
        }

        private void Execute(UserEntity model)
        {
            try
            {
                _repository.Create(model);
            }
            catch (Exception exception)
            {
                //Normally we would not do like this but activate
                // one of the OTE framework libraries to catch unhandled exceptions in the top layer.
                //
                // It gives much cleaner code.
                // 
                // This sample just do this as an demonstration.
                OneTrue.Report(exception, model);
            }
        }
    }
}