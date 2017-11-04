using App.Common.Constants;
using App.DBLayer.Repositories;

namespace App.BusinessLogicLayer.Factories
{
    public class RepositoryFactory
    {
        public static MemberRepository GetMemberRepository()
        {
            return new MemberRepository(DataAccess.ConnectionString);
        }
    }
}
