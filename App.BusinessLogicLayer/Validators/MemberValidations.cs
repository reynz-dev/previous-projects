using System.Collections.Generic;
using App.BusinessLogicLayer.Factories;
using App.Common.Entities;

namespace App.BusinessLogicLayer.Validators
{
    public class MemberValidations
    {
        public static IEnumerable<Member> GetMembers()
        {
            if (!Validate()) return null;
            var memberRepository = RepositoryFactory.GetMemberRepository();
            return memberRepository.GetMembers();
        }

        private static bool Validate()
        {
            return true;
        }
    }

    
}
