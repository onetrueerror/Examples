using System.Data;

namespace Manual_Reporting.IncludeDTO
{
    public class UserRepository
    {
        public void Create(UserEntity entity)
        {
            throw new DataException("Failed to connect to database.");
        }
    }
}