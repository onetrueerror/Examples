using System;
using System.Data;

namespace Manual_Reporting.SuportsDynamicAsContextInfo
{
    public class UserRepository
    {
        public void Create(string userName, DateTime createdAtUtc)
        {
            throw new DataException("Failed to connect to database.");
        }
    }
}