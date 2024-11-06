using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IMemberService
    {
        void CreateMember(Member member);
        List<Member> GetMembers();
        Member GetMember(int id);
        void UpdateMember(Member member);
        void DeleteMember(Member member);
        Member MemberLogin(string email, string password);
    }
}
